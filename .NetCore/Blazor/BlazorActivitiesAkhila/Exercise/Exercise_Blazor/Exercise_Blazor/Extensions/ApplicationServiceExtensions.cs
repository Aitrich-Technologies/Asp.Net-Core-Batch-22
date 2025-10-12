using Microsoft.EntityFrameworkCore;
using Exercise_Blazor.Repository;
using Exercise_Blazor.Services;
using Exercise_Blazor.Model;
namespace Exercise_Blazor.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<JobDetailsRepository>();
            services.AddScoped<JobDetailServices>();
            return services;
        }
    }
}
