using AutoMapper;
using LibrarySystem.Dto;
using LibrarySystem.Model;

namespace LibrarySystem.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
