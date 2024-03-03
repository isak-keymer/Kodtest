using AutoMapper;
using KodtestMio.DbModel.EntityModels;
using KodtestMio.Dto.RequestParameters;

namespace KodtestMio.Dto.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, CreateOrderRequest>().ReverseMap();

            CreateMap<OrderItem, CreateOrderItemRequest>().ReverseMap();

            CreateMap<Order, OrderDto>().ReverseMap();

            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        }

    }
}
