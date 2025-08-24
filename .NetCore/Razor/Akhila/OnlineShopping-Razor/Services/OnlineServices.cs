using Microsoft.AspNetCore.Mvc;
using OnlineShopping_Razor.Model;
using OnlineShopping_Razor.Repository;

namespace OnlineShopping_Razor.Services
{
    public class OnlineServices
    {
        private readonly OnlineRepository _repository;
        public OnlineServices(OnlineRepository repository)
        {
            _repository= repository;
        }
        public async Task<IList<Product>> GetAllProducts()
        {
            return await _repository.GetAllProducts();
        }       
        public async Task<IList<Product>> GetCartProducts()
        {
            return await _repository.GetCartProducts();
        }
        public async Task AddNewUserAsync(OnlineUser newuser)
        {
            await _repository.AddNewUser(newuser);
        }

        public async Task<bool> VerifyUser(string Username, string Password)
        {
            return await _repository.VerifyUser(Username, Password);
        }
    }
}
