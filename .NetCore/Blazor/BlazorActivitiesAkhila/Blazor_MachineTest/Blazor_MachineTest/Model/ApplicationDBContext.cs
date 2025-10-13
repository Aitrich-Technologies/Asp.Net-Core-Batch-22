using Microsoft.EntityFrameworkCore;
namespace Blazor_MachineTest.Model
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base (options) { }
        public DbSet<Pet> Pets { get; set; }
    }
}
