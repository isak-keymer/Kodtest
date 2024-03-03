namespace KodtestMio.Dto
{
    public class OrderItemDto
    {
        /// <summary>
        /// The unique identifier for the orderItem.
        /// </summary>
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
    }
}
