using Microsoft.EntityFrameworkCore;
using OnlineShopping_Razor.Model;
using OnlineShopping_Razor.Repository;
using OnlineShopping_Razor.Services;
using System.Runtime.CompilerServices;
namespace OnlineShopping_Razor.Extentions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<OnlineServices>();
            services.AddScoped<OnlineRepository>();
            services.AddSession();
            services.AddHttpContextAccessor();

            return services;
        
        }
    }
}
