namespace KodtestMio.Dto.RequestParameters
{
    public class CreateOrderRequest
    {
        public required string CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
        public required decimal TotalAmount { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required List<CreateOrderItemRequest> OrderItems { get; set; }
    }
}
