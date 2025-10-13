using AutoMapper;
using Blazor_MachineTest.Dto;
using Blazor_MachineTest.Model;

namespace Blazor_MachineTest.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pet, PetDto>().ReverseMap();
        }
    }
}
