using Microsoft.EntityFrameworkCore;

namespace WebApplication3_Activity.StudentRecord
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<StudentRcrd> studentRcrds { get; set; }
            
    }
}
