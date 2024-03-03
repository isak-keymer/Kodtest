using System.ComponentModel.DataAnnotations;

namespace KodtestMio.DbModel.EntityModels
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
        public required decimal TotalAmount { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required List<OrderItem> OrderItems { get; set; }
    }
}
