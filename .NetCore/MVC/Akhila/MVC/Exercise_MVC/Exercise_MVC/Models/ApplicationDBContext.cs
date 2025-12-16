using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Exercise_MVC.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
       
        public DbSet<Job> Jobs { get; set; }
    }
}
