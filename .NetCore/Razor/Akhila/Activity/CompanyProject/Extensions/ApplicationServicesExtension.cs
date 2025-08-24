using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using CompanyProject.Model;
using CompanyProject.Repository;
using CompanyProject.Services;
using CompanyProject.Helper;

namespace CompanyProject.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
           
            services.AddScoped<CompanyServices>();
            services.AddScoped<CompanyRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddSession();
          
            return services;
        }
    }
}
