using AutoMapper;
using CompanyProject.Dto;
using CompanyProject.Model;

namespace CompanyProject.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CompanyUser, CompanyUserDto>().ReverseMap();
            CreateMap<CompanyMember, CompanyMemberDto>().ReverseMap();
        }
    }
}
