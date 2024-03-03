using System.Text.Json.Serialization;

namespace KodtestMio.Dto.RequestParameters
{
    public class UpdateProductRequest
    {
        /// <summary>
        /// The name for the product.
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; set; }
        /// <summary>
        /// The description for the product.
        /// </summary>
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        /// <summary>
        /// The products price.
        /// </summary>
        [JsonPropertyName("price")]
        public required decimal Price { get; set; }
        /// <summary>
        /// The stock balance for the product.
        /// </summary>
        [JsonPropertyName("stock")]
        public required int Stock { get; set; }
        /// <summary>
        /// An image url to the the CMS for the product.
        /// </summary>
        [JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }
    }
}
