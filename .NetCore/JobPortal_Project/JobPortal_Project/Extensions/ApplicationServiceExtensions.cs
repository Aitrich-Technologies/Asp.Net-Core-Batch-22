using Domain.Models;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_Project.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbHireMeNowWebApiContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IAuthUserService, AuthUserService>();
            return services;
        }
    }
}
