using KodtestMio.DbModel.EntityModels;
using KodtestMio.DbModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KodtestMio.Services;
using KodtestMio.Dto.RequestParameters;
using AutoMapper;
using KodtestMio.Dto;

namespace KodtestMio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : Controller
    {
        private OrderService _orderService;
        private IMapper _mapper;
        public OrdersController(OrderService orderService, IMapper mapper)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        /// <summary>
        /// Returns all orders.
        /// </summary>
        /// <response code="200">Returns all orders</response>
        /// <response code="404">If no orders are found</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            if (orders.Count == 0)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<OrderDto>>(orders));
        }

        /// <summary>
        /// Gets a specific order by id.
        /// </summary>
        /// <param name="id">The unique identifier of the order.</param>
        /// <returns>The order details.</returns>
        /// <response code="200">Returns the order details</response>
        /// <response code="404">If the order is not found</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetOrderById(int id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderDto>(order));
        }

        /// <summary>
        /// Add a new order. Decreases balance for products in the order
        /// </summary>
        /// <response code="201">Returns the order details</response>
        /// <response code="400">Bad request</response>
        /// <response code="409">If the order has validation errors, like non-existing products ids or to large quantities requested.</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [HttpPost]
        public async Task<ActionResult<OrderDto>> PostOrder([FromBody] CreateOrderRequest createOrderRequest)
        {
            var result = await _orderService.PostOrderAsync(createOrderRequest);
            if(result.Success) 
            {
                return CreatedAtAction(nameof(GetOrderById), new { id = result.Order?.Id }, _mapper.Map<OrderDto>(result.Order));
            }
            if(result.StatusCode == 409) 
            {
                return StatusCode(StatusCodes.Status409Conflict, result.ErrorMessage);
            }
            return BadRequest();
        }

        /// <summary>
        /// Deletes an order. Increases balance for products removed from the order.
        /// </summary>
        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            var result = await _orderService.DeleteOrderAsync(order);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result.ErrorMessage);
        }
    }
}
