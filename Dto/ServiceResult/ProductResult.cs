using KodtestMio.DbModel.EntityModels;

namespace KodtestMio.Dto.ServiceResult
{
    public class ProductResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public int? StatusCode { get; set; }
        public Product? Product { get; set; }
    }
}
