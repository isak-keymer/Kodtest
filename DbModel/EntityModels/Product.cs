using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace KodtestMio.DbModel.EntityModels
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("price")]
        public required decimal Price { get; set; }
        
        [JsonPropertyName("stock")]
        public required int Stock { get; set; }
        
        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }
    }
}
