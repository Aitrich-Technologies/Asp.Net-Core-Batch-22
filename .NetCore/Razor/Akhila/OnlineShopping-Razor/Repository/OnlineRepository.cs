using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShopping_Razor.Model;

namespace OnlineShopping_Razor.Repository
{
    public class OnlineRepository
    {
        private readonly ApplicationDBContext _context;
        private OnlineUser user { get; set; } = new OnlineUser();
        public OnlineRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IList<Product>> GetAllProducts()
        {
            var Products = await _context.OnlineProducts.ToListAsync();
            return Products;
        }

        public async Task<IList<Product>> GetCartProducts()
        {
            var products = await _context.OnlineProducts.Where(p => p.Status == 1).ToListAsync();
            return products;
        }
        public async Task AddNewUser(OnlineUser newuser)
        {
            _context.OnlineUsers.Add(newuser);
            await _context.SaveChangesAsync();

        }
        public async Task<bool> VerifyUser(string Username, string Password)
        {
            var loguser=_context.OnlineUsers.SingleOrDefaultAsync(u=> u.username==Username && u.password==Password);
            if (loguser == null)
            { return false; }
            else
            { return true; }
        }
    }
}
