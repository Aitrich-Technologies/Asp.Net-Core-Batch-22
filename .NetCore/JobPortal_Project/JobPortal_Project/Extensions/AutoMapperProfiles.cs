
using AutoMapper;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Service.Profile.DTOs;
using Domain.Service.SignUp.DTOs;
using JobPortal_Project.API.JobSeeker.RequestObjects;


namespace HireMeNow_WebApi.Extensions
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<JobSeekerSignupRequestDto, SignUpRequest>().ReverseMap();
            CreateMap<JobSeekerSignupRequest, JobSeekerSignupRequestDto>().ReverseMap();
            CreateMap<SignUpRequest, SystemUser>().ReverseMap();
            CreateMap<AuthUser, Domain.Models.JobSeeker>().ReverseMap();
            CreateMap<AuthUser, JobSeekerLoginDto>();
            CreateMap<ProfileDto, JobSeekerProfile>().ReverseMap();
            CreateMap<JobPost, JobPostDto>();
            CreateMap<JobPost, JobSearchDto>();
        }
    }
}
