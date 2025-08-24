using LibrarySystem.Dto;
using LibrarySystem.Model;
using LibrarySystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace LibrarySystem.Services
{
    public class LibraryServices
    {
        private readonly LibraryRepository _repository;          
        public LibraryServices(LibraryRepository repository)
        {
            _repository = repository;
        }
        public async Task<IList<BookDto>> GetAllBooksAsync()
        {
            return await _repository.GetAllBooksAsync();
        }

        public async Task AddNewBookAsync(BookDto Newbook)
        {
            await _repository.AddNewBookAsync(Newbook);
        }
        public async Task GetBookbyIdAsync(int id)
        {
             await _repository.GetBookbyIdAsync(id);
        }

        public async Task<bool> ValidateRoleAsync(string Role,string Password)
        {
            return await _repository.ValidateRoleAsync(Role, Password);
        }

        public async Task AddNewUserAsync(string name,string password)
        {
            await _repository.AddNewUserAsync(name, password);
        }
    }
}
