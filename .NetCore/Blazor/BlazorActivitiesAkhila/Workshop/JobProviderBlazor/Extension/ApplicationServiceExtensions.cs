
using JobProviderBlazor.Helper;
using JobProviderBlazor.Model;
using JobProviderBlazor.Repository;
using JobProviderBlazor.Service;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace JobProviderBlazor.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddScoped<JobProviderRepository>();
            services.AddScoped<JobRepository>();
     
            services.AddScoped<JobProviderService>();
            services.AddScoped<JobService>();

            return services;
        }
    }
}
