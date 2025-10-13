using Microsoft.EntityFrameworkCore;
namespace JobProviderBlazor.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
            public DbSet<Job> Jobs { get; set; }
        public DbSet<JobProvider> JobProviders { get; set; }
    }
}
