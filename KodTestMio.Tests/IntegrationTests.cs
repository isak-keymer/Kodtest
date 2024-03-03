using AutoMapper;
using KodtestMio.DbModel;
using KodtestMio.DbModel.EntityModels;
using KodtestMio.Dto.Profiles;
using KodtestMio.Dto.RequestParameters;
using KodtestMio.Services;
using Microsoft.EntityFrameworkCore;

namespace KodTestMio.Tests
{
    public class IntegrationTests : IDisposable
    {
        private readonly RetailDbContext _context;
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly IMapper _mapper;

        public IntegrationTests()
        {
            Environment.SetEnvironmentVariable("IsRunningFromTests", "true");

            var options = new DbContextOptionsBuilder<RetailDbContext>()
                .UseSqlite("Filename=:memory:")
                .Options;

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<OrderProfile>();
                cfg.AddProfile<ProductProfile>();
            });

            _mapper = mapperConfig.CreateMapper();

            _context = new RetailDbContext(options);
            _context.Database.OpenConnection();
            _context.Database.EnsureCreated();

            _productService = new ProductService(_context, _mapper);
            _orderService = new OrderService(_mapper, _context, _productService);
        }

        [Fact]
        public async Task GetAllProductsAsync_ReturnsAllProducts()
        {
            // Arrange
            _context.Products.Add(new Product { Id = 1, Name = "Test Product 1", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" });
            _context.Products.Add(new Product { Id = 2, Name = "Test Product 2", Description = "desc2", Price = 240, Stock = 50, ImageUrl = "pic02.png" });
            _context.SaveChanges();

            // Act
            var products = await _productService.GetAllProductsAsync();

            // Assert
            Assert.Equal(2, products.Count);
        }

        [Fact]
        public async Task GetProductByIdAsync_ReturnsProductWithId()
        {
            // Arrange
            _context.Products.Add(new Product { Id = 1, Name = "Test Product 1", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" });
            _context.Products.Add(new Product { Id = 2, Name = "Test Product 2", Description = "desc2", Price = 240, Stock = 50, ImageUrl = "pic02.png" });
            _context.SaveChanges();

            // Act
            var product = await _productService.GetProductByIdAsync(1);

            // Assert
            Assert.Equal(1, product.Id);
        }

        [Fact]
        public async Task PostProductAsync_ProductAdded()
        {
            // Arrange
            var product = new CreateProductRequest { Name = "Test Product 1", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" };

            // Act
            var productResult = await _productService.PostProductAsync(product);
            var addedProduct = productResult.Product;

            // Assert
            Assert.True(productResult.Success);
            Assert.Equal(product.Name, addedProduct.Name);
        }

        [Fact]
        public async Task UpdateProductAsync_ProductUpdated()
        {
            // Arrange
            var productToUpdate = new Product { Id = 1, Name = "Test Product 1", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" };
            _context.Products.Add(productToUpdate);
            _context.SaveChanges();
            var updateProductRequest = new UpdateProductRequest { Name = "ChangedName", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" };
            
            // Act
            var result = await _productService.UpdateProductAsync(1, updateProductRequest);
            var product = await _productService.GetProductByIdAsync(1);

            // Assert
            Assert.Equal("ChangedName", product.Name);
            Assert.True(result.Success);
        }

        [Fact]
        public async Task UpdateProductBalanceAsync_BalanceUpdated()
        {
            // Arrange
            _context.Products.Add(new Product { Id = 1, Name = "Test Product 1", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" });
            _context.SaveChanges();

            // Act
            await _productService.UpdateProductBalanceAsync(1,3);
            var updatedProduct = await _productService.GetProductByIdAsync(1);

            // Assert
            Assert.Equal(97, updatedProduct.Stock);
        }

        [Fact]
        public async Task DeleteProductAsync_ProductDeleted()
        {
            // Arrange
            var productToDelete = new Product { Id = 1, Name = "Test Product 1", Description = "desc1", Price = 130, Stock = 100, ImageUrl = "pic01.png" };
            _context.Products.Add(productToDelete);
            _context.SaveChanges();

            // Act
            await _productService.DeleteProductAsync(productToDelete);

            // Assert
            Assert.Empty(await _productService.GetAllProductsAsync());
        }

        [Fact]
        public async Task GetAllOrdersAsync_ReturnsAllOrders()
        {
            // Arrange
            _context.Orders.Add(
                new Order
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    CustomerEmail = "testmail@test.com",
                    CustomerName = "Isak",
                    TotalAmount = 500,
                    OrderItems =
                        new List<OrderItem>()
                        {
                            new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Price = 250, Quantity = 2 }
                        }
                });

            _context.SaveChanges();

            // Act
            var orders = await _orderService.GetAllOrdersAsync();

            // Assert
            Assert.Single(orders);
        }

        [Fact]
        public async Task GetOrderByIdAsync_ReturnsOneOrderWithId()
        {
            // Arrange
            _context.Orders.Add(
                new Order
                {
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    CustomerEmail = "testmail@test.com",
                    CustomerName = "Isak",
                    TotalAmount = 500,
                    OrderItems =
                        new List<OrderItem>()
                        {
                            new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Price = 250, Quantity = 2 }
                        }
                });

            _context.SaveChanges();

            // Act
            var order = await _orderService.GetOrderByIdAsync(1);

            // Assert
            Assert.Equal(1, order.Id);
        }

        [Fact]
        public async Task PostOrderAsync_OrderWithOrderItemAdded()
        {
            // Arrange
            _context.Products.Add(new Product { Id = 1, Name = "Test Product 2", Description = "desc2", Price = 240, Stock = 50, ImageUrl = "pic02.png" });
            _context.SaveChanges();

            var createOrderRequest = 
                new CreateOrderRequest
                {
                    CreatedAt = DateTime.Now,
                    CustomerEmail = "testmail@test.com",
                    CustomerName = "Isak",
                    TotalAmount = 500,
                    OrderItems =
                        new List<CreateOrderItemRequest>()
                        {
                            new CreateOrderItemRequest { ProductId = 1, Price = 250, Quantity = 2 }
                        }
                };

            // Act
            var orderResult = await _orderService.PostOrderAsync(createOrderRequest);
            var product = await _productService.GetProductByIdAsync(1);
            var orders = await _orderService.GetAllOrdersAsync();

            // Assert
            Assert.Single(orders);
            Assert.True(orderResult.Success);
            Assert.Equal(48, product.Stock);
        }

        [Fact]
        public async Task PostOrderAsync_OrderItemNotInStock()
        {
            // Arrange
            _context.Products.Add(new Product { Id = 1, Name = "Test Product 2", Description = "desc2", Price = 240, Stock = 3, ImageUrl = "pic02.png" });
            _context.SaveChanges();

            var createOrderRequest =
                new CreateOrderRequest
                {
                    CreatedAt = DateTime.Now,
                    CustomerEmail = "testmail@test.com",
                    CustomerName = "Isak",
                    TotalAmount = 500,
                    OrderItems =
                        new List<CreateOrderItemRequest>()
                        {
                            new CreateOrderItemRequest { ProductId = 1, Price = 250, Quantity = 5 }
                        }
                };

            // Act
            var orderResult = await _orderService.PostOrderAsync(createOrderRequest);

            // Assert
            Assert.False(orderResult.Success);
            Assert.NotEmpty(orderResult.ErrorMessage);
        }

        [Fact]
        public async Task DeleteOrderAsync_OrderWithOrderItemDeleted()
        {
            // Arrange
            _context.Products.Add(new Product { Id = 1, Name = "Test Product 2", Description = "desc2", Price = 240, Stock = 50, ImageUrl = "pic02.png" });
            _context.Orders.Add(new Order
            {
                Id = 1,
                CreatedAt = DateTime.Now,
                CustomerEmail = "testmail@test.com",
                CustomerName = "Isak",
                TotalAmount = 500,
                OrderItems =
                    new List<OrderItem>()
                    {
                        new OrderItem { Id = 1, OrderId = 1, ProductId = 1, Price = 250, Quantity = 2 }
                    }
            });

            _context.SaveChanges();

            // Act
            var order = await _orderService.GetOrderByIdAsync(1);
            var orderResult = await _orderService.DeleteOrderAsync(order);
            var product = await _productService.GetProductByIdAsync(1);

            // Assert
            Assert.True(orderResult.Success);
            Assert.Equal(52, product.Stock);
        }   

        public void Dispose()
        {
            _context.Database.CloseConnection(); 
            _context.Dispose();
        }
    }
}
