using KodtestMio.DbModel.EntityModels;
using KodtestMio.DbModel;
using Microsoft.EntityFrameworkCore;
using KodtestMio.Dto.RequestParameters;
using System.Reflection;
using KodtestMio.Dto.ServiceResult;
using AutoMapper;

namespace KodtestMio.Services
{
    public class ProductService
    {
        private readonly RetailDbContext _context;
        private IMapper _mapper;

        public ProductService(RetailDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<ProductResult> PostProductAsync(CreateProductRequest createProductRequest)
        {
            try
            {
                var product = _mapper.Map<Product>(createProductRequest);
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return new ProductResult { Success = true, Product = product };
            }
            catch (Exception)
            {
                return new ProductResult { Success = false, ErrorMessage = "Failed to create a new product" };
            }
        }

        public async Task<ProductResult> UpdateProductAsync(int id, UpdateProductRequest updateProductRequest)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return new ProductResult { Success = false, ErrorMessage = "Product to update not found", StatusCode = 404 };
            }

            try
            {
                UpdateProduct(product, updateProductRequest);
                _context.Entry(product).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return new ProductResult { Success = true };
            }
            catch (Exception)
            {
                return new ProductResult { Success = false, ErrorMessage = "Failed to update product"};
            }
        }

        public async Task UpdateProductBalanceAsync(int id, int balanceChange)
        {
            var productToUpdate = await _context.Products.FindAsync(id);

            if (productToUpdate != null)
            {
                productToUpdate.Stock -= balanceChange;
                _context.Entry(productToUpdate).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ProductResult> DeleteProductAsync(Product product)
        {
            try
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return new ProductResult { Success = true };
            }
            catch(Exception) 
            {
                return new ProductResult { Success = false, ErrorMessage = $"Unable to delete product with id {product.Id}" };
            }
        }

        private void UpdateProduct(Product product, UpdateProductRequest updateProductRequest)
        {
            PropertyInfo[] requestProperties = typeof(UpdateProductRequest).GetProperties();
            PropertyInfo[] productProperties = typeof(Product).GetProperties();

            foreach (var requestProp in requestProperties)
            {
                foreach (var productProp in productProperties)
                {
                    if (requestProp.Name == productProp.Name && requestProp.PropertyType == productProp.PropertyType)
                    {
                        productProp.SetValue(product, requestProp.GetValue(updateProductRequest));
                        break;
                    }
                }
            }
        }
        
        public IEnumerable<int> ValidateEnoughInStock(IEnumerable<CreateOrderItemRequest> createOrderItemRequests)
        {
            var productsInShortage = new List<int>();
            foreach(var request in createOrderItemRequests) 
            {
                if(_context.Products.Any(x => x.Id == request.ProductId && x.Stock < request.Quantity))
                {
                    productsInShortage.Add(request.ProductId);
                }
            }
            return productsInShortage;
        }

        public IEnumerable<int> ValidateProductsInOrder(IEnumerable<int> productIdsFromRequest)
        {
            var existingProductIds = _context.Products.Where(x => productIdsFromRequest.Contains(x.Id)).Select(x => x.Id).ToList();
             return productIdsFromRequest.Except(existingProductIds).ToList();
        }
    }
}
