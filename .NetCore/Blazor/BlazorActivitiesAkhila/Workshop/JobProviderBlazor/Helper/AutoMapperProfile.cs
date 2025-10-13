using AutoMapper;
using JobProviderBlazor.Dto;
using JobProviderBlazor.Model;

namespace JobProviderBlazor.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<JobProvider, JobProviderDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
        }
    }
}
