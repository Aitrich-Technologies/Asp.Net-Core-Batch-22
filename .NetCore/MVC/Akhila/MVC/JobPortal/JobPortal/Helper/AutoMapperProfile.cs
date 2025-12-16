using AutoMapper;
using JobPortal.Dto;
using JobPortal.Models;

namespace JobPortal.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job,IndexJobDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
        }
    }
}
