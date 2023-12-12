using AutoMapper;
using Marcos_Pizza.Data;
using Marcos_Pizza.Models;

namespace Marcos_Pizza.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Orders, OrderVM>().ReverseMap();
            CreateMap<Products, ProductVM>().ReverseMap();
            CreateMap<UserVM, UserVM>().ReverseMap();
        }
    }
}
