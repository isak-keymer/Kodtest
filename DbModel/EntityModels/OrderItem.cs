using System.ComponentModel.DataAnnotations;

namespace KodtestMio.DbModel.EntityModels
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public required int Quantity { get; set; }
        public required decimal Price { get; set; }
    }
}
