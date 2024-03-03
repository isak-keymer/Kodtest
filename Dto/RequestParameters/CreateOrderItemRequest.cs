namespace KodtestMio.Dto.RequestParameters
{
    public class CreateOrderItemRequest
    {
        public int ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
    }
}
