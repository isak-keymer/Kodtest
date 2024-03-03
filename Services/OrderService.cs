using AutoMapper;
using KodtestMio.DbModel;
using KodtestMio.DbModel.EntityModels;
using KodtestMio.Dto.RequestParameters;
using KodtestMio.Dto.ServiceResult;
using Microsoft.EntityFrameworkCore;

namespace KodtestMio.Services
{
    public class OrderService
    {
        private readonly RetailDbContext _context;
        private readonly ProductService _productService;
        private readonly IMapper _mapper;

        public OrderService(IMapper mapper, RetailDbContext context, ProductService productService)
        {
            _mapper = mapper;
            _context = context;
            _productService = productService;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.Include(x => x.OrderItems).ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _context.Orders.Include(x => x.OrderItems).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<OrderResult> PostOrderAsync(CreateOrderRequest createOrderRequest)
        {
            var productIdsFromRequest = createOrderRequest.OrderItems.Select(x => x.ProductId).ToList();
            var invalidProductIds = _productService.ValidateProductsInOrder(productIdsFromRequest);
            
            var productsInShortage = _productService.ValidateEnoughInStock(createOrderRequest.OrderItems.Where(x => !invalidProductIds.Contains(x.ProductId)));
            
            if (invalidProductIds.Count() > 0 || productsInShortage.Count() > 0)
            {
                return new OrderResult { Success = false, StatusCode = 409, ErrorMessage = ProductValidationErrorMessage(invalidProductIds, productsInShortage) };
            }

            try
            {
                var order = _mapper.Map<Order>(createOrderRequest);

                _context.Orders.Add(order);
                await _context.SaveChangesAsync();

                foreach (var item in order.OrderItems)
                {
                    await _productService.UpdateProductBalanceAsync(item.ProductId, item.Quantity);
                }

                return new OrderResult { Success = true, Order = order };
            }
            catch (Exception)
            {
                return new OrderResult { Success = false, ErrorMessage = "Failed to create a new order", StatusCode = 500 };
            }
        }

        public async Task<OrderResult> DeleteOrderAsync(Order order)
        {
            try
            {
                foreach (var item in order.OrderItems)
                {
                    await _productService.UpdateProductBalanceAsync(item.ProductId, -item.Quantity);
                }

                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
                return new OrderResult { Success = true };
            }
            catch (Exception)
            {
                return new OrderResult { Success = false, ErrorMessage = $"Failed to delete order with id {order.Id}"};
            }
        }

        private string ProductValidationErrorMessage(IEnumerable<int> invalidProductIds, IEnumerable<int> productsInShortage)
        {
            var errorMessage = string.Empty;
            if (invalidProductIds.Count() > 0)
            {
                errorMessage += $"Invalid product ids: {string.Join(", ", invalidProductIds)} ";
            }
            if (productsInShortage.Count() > 0)
            {
                errorMessage += $"Product ids in short supply: {string.Join(", ", productsInShortage)}";
            }
            return errorMessage;
        }
    }
}
