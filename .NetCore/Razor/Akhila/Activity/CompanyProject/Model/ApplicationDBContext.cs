using CompanyProject.Dto;
using Microsoft.EntityFrameworkCore;
namespace CompanyProject.Model
{
    public class ApplicationDBContext:DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options) 
        { }

        
        public DbSet<CompanyUser> companyUsers { get; set; }
        public DbSet<CompanyMember> companyMembers { get; set; }
    }
}
