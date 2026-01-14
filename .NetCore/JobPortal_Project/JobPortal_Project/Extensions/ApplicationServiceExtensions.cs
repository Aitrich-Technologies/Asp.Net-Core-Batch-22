using Domain.Models;
using Domain.Service;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobProvider;
using Domain.Service.JobProvider.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Project.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                sqlOptions => sqlOptions.MigrationsAssembly("Domain"))
            );
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IJobProviderService, JobProviderService>();
            services.AddScoped<IJobProviderRepository, JobProviderRepository>();
            services.AddScoped<IEMailService,EmailService>();
          
            //services.AddScoped<IAuthUserService, AuthUserService>();
            return services;
        }
    }
}
