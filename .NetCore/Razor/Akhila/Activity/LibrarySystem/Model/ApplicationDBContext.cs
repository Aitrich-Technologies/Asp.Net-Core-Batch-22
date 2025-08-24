using Microsoft.EntityFrameworkCore;
namespace LibrarySystem.Model
{
    public class ApplicationDBContext:DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<LibraryRole> LibraryRoles { get;set; }
    }
}
