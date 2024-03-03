using AutoMapper;
using KodtestMio.DbModel;
using KodtestMio.DbModel.EntityModels;
using KodtestMio.Dto;
using KodtestMio.Dto.RequestParameters;
using KodtestMio.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace KodtestMio.Controllers
{
    /// <summary>
    /// API for operations regarding products
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private ProductService _productService;
        private IMapper _mapper;
        public ProductsController(ProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns all products.
        /// </summary>
        /// <response code="200">Returns all products</response>
        /// <response code="404">If no products are found</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();

            if(products.Count == 0) 
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(products));
        }

        /// <summary>
        /// Gets a specific product by id.
        /// </summary>
        /// <param name="id">The unique identifier of the product.</param>
        /// <returns>The product details.</returns>
        /// <response code="200">Returns the product details</response>
        /// <response code="404">If the product is not found</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(product));
        }

        /// <summary>
        /// Add a new product.
        /// </summary>
        /// <param name="createProductRequest">The product details required to create a new product.</param>
        /// <returns>The newly created product.</returns>
        /// <response code="201">Returns the product details</response>
        /// <response code="400">If the product could not be added</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult<ProductDto>> PostProduct([FromBody] CreateProductRequest createProductRequest)
        {
            var result = await _productService.PostProductAsync(createProductRequest);
            if (result.Success)
            {
                return CreatedAtAction(nameof(GetProductById), new { id = result.Product?.Id }, _mapper.Map<ProductDto>(result.Product));
            }

            return BadRequest("Could not add product");
        }

        /// <summary>
        /// Update an existing product.
        /// </summary>
        /// <param name="id">The unique identifier of the product to update.</param>
        /// <param name="updateProductRequest">The product details required to update an existing product.</param>
        /// <returns>No content.</returns>
        /// <response code="204">No content</response>
        /// <response code="400">If the product could not be updated</response>
        /// <response code="404">If the product is not found</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductRequest updateProductRequest)
        {
            var result = await _productService.UpdateProductAsync(id, updateProductRequest);
            if (result.Success)
            {
                return NoContent();
            }

            switch (result.StatusCode)
            {
                case 404:
                    return NotFound();
                default:
                    return BadRequest(result.ErrorMessage);
            }
        }

        /// <summary>
        /// Deletes an existing product.
        /// </summary>
        /// <param name="id">The unique identifier of the product.</param>
        /// <returns>No content.</returns>
        /// <response code="204">No content</response>
        /// <response code="404">If the product is not found</response>
        /// <response code="503">Server unavailable</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var result = await _productService.DeleteProductAsync(product);
            if(result.Success)
            {
                return NoContent();
            }

            switch(result.StatusCode)
            {
                case 404:
                    return NotFound(result.ErrorMessage);
                default:
                    return BadRequest(result.ErrorMessage);
            }
        }
    }
}
