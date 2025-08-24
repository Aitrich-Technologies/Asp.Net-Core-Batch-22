using Activity_Razor.Dto;
using Activity_Razor.Model;
using AutoMapper;
//using Activity_Razor.Dto;
//using Activity_Razor.Model;
//using System.Runtime;

namespace Activity_Razor.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        { 
        CreateMap<Student, StudentDto>().ReverseMap();
        }
      
    }
}
