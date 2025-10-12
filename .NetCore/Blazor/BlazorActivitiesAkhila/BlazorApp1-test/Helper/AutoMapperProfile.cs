using AutoMapper;
using BlazorApp1_test.Dto;
using BlazorApp1_test.Model;

namespace BlazorApp1_test.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<name, nameDto>().ReverseMap();
        }
    }
}
