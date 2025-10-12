using BlazorApp1_test.Helper;
using BlazorApp1_test.Model;
using BlazorApp1_test.Dto;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace BlazorApp1_test.Repository
{
    public class NameRepository
    {
        private readonly IMapper mapper;
        public List<name> names = new List<name>()
            {
                new name{Id=1,Name="Atul"},
                new name{Id=2,Name="Ravi"},
                new name{Id=3,Name="Ani"}
            };
        public NameRepository(IMapper map)

        {
            mapper = map;
        }
        public List<nameDto> GetNames()

        {
           
           
            return mapper.Map<List<nameDto>>(names);
        }

        public async Task AddNewName(name newname)
        {
            names.Add(newname);
        }
        public name getbyid(string deletename)
        {
            return names.FirstOrDefault(n => n.Name == deletename);
        }
        public void deletenamebyname(string deletename)
        {
          
            names.Remove(getbyid(deletename));
        }
        //public void updatename(name nam)
        //{
        //    names.getbyid(nam.Name);
        //}
    }
}
