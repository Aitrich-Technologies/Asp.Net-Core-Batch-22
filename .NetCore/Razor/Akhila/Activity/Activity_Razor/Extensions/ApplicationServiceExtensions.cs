using Activity_Razor.Helper;
using Activity_Razor.Model;
using Activity_Razor.Service;
using Activity_Razor.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Activity_Razor.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            

            // Add Services
            services.AddScoped<StudentService>();
            services.AddScoped<StudentRepository>();
            // Add AutoMapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
