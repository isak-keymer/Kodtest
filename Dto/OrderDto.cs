namespace KodtestMio.Dto
{
    public class OrderDto
    {
        /// <summary>
        /// The unique identifier for the order.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the customer creating the order.
        /// </summary>
        public required string CustomerName { get; set; }
        /// <summary>
        /// The mail of the customer creating the order.
        /// </summary>
        public required string CustomerEmail { get; set; }
        /// <summary>
        /// The total amount of all order items combined
        /// </summary>
        public required decimal TotalAmount { get; set; }
        /// <summary>
        /// The date the order was created
        /// </summary>
        public required DateTime CreatedAt { get; set; }
        /// <summary>
        /// List of all items specified in the order, quantity, price etc.
        /// </summary>
        public required List<OrderItemDto> OrderItems { get; set; }
    }
}
