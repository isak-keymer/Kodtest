using KodtestMio.DbModel.EntityModels;
using KodtestMio.Dto.RequestParameters;
using AutoMapper;

namespace KodtestMio.Dto.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, CreateProductRequest>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
