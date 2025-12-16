using Exercise_MVC.Helper;
using Exercise_MVC.Models;
using Exercise_MVC.AppServices;
using Exercise_MVC.AppRepository;

using Microsoft.EntityFrameworkCore;

namespace Exercise_MVC.Extentions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddSession();
            services.AddScoped<ApplicationServices>();
            services.AddScoped<ApplicationRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
