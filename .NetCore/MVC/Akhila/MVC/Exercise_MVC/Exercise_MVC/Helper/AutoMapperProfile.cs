using AutoMapper;
using Exercise_MVC.Dto;
using Exercise_MVC.Models;

namespace Exercise_MVC.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User,Login_Dto>().ReverseMap();
                
        }
    }
}
