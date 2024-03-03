using KodtestMio.DbModel.EntityModels;

namespace KodtestMio.Dto.ServiceResult
{
    public class OrderResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public int? StatusCode { get; set; }
        public Order? Order { get; set; }
    }
}
