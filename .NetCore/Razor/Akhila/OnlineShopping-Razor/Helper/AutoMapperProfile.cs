using AutoMapper;
using OnlineShopping_Razor.Dto;
using OnlineShopping_Razor.Model;

namespace OnlineShopping_Razor.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Product,ProductDto>().ReverseMap();
        }
    }
}
