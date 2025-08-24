using AutoMapper;
using LibrarySystem.Dto;
using LibrarySystem.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LibrarySystem.Repository
{
    public class LibraryRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public LibraryRepository(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public LibraryRole user { get; set; } = new LibraryRole();
        public async Task<IList<BookDto>> GetAllBooksAsync()
        {
            var BookList = await _dbContext.Books.ToListAsync();
            return _mapper.Map<List<BookDto>>(BookList);
        }

        public async Task AddNewBookAsync(BookDto Newbook)
        {
            var newbook = _mapper.Map<Book>(Newbook);
            _dbContext.Books.Add(newbook);
            await _dbContext.SaveChangesAsync();
        }

        public async Task GetBookbyIdAsync(int id)
        {
            var bookdelete = await _dbContext.Books.FindAsync(id);
           
            _dbContext.Books.Remove(bookdelete);
            await _dbContext.SaveChangesAsync();

        }

        public async Task<bool> ValidateRoleAsync(string Role,string Password)
        {
           var loginuser=_dbContext.LibraryRoles.SingleOrDefault(u=>u.UserRole == Role && u.Password==Password);
            if (loginuser == null) { return false; }
            else { return true; }
          
        }


        public async Task AddNewUserAsync(string name,string password)
        {
            user.UserRole = name;
            user.Password = password;
            _dbContext.LibraryRoles.Add(user);
            await _dbContext.SaveChangesAsync();
        }


    }
}
