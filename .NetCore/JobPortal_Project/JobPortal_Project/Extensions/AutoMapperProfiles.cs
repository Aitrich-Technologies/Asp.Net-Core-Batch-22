

using AutoMapper;
using Domain.Models;
using Domain.Service.SignUp.DTOs;
using JobPortal_Project.API.JobProvider.RequestObjects;


namespace HireMeNow_WebApi.Extensions
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobProviderSignupRequestDto,JobProviderSignupRequest>().ReverseMap();
            CreateMap<SignUpRequest,JobProviderSignupRequestDto>().ReverseMap();

        }
    }
}
