using AutoMapper;
using Marcos_Pizza.Data;
using Marcos_Pizza.Models;

namespace Marcos_Pizza.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Order, OrderVM>().ReverseMap();
            CreateMap<ProductC, ProductVM>().ReverseMap();
            CreateMap<UserVM, UserVM>().ReverseMap();
        }
    }
}
