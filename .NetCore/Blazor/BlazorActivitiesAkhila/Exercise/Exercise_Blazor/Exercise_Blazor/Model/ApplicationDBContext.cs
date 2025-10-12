using Microsoft.EntityFrameworkCore;

namespace Exercise_Blazor.Model
{
    public class ApplicationDBContext:DbContext    
    {
        internal readonly object Jobs;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) : base(options) { }
        public DbSet<JobDetail> JobDetails { get; set; }
    }
}
