using Microsoft.EntityFrameworkCore;
namespace OnlineShopping_Razor.Model
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<OnlineUser> OnlineUsers { get; set; }
        public DbSet<Product> OnlineProducts { get; set; }
    }
}
