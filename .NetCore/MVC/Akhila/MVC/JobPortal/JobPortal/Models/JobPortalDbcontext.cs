using Microsoft.EntityFrameworkCore;

namespace JobPortal.Models
{
    public class JobPortalDbcontext:DbContext
    {
        public JobPortalDbcontext(DbContextOptions<JobPortalDbcontext> options) : base(options) { }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }  
    }
}
