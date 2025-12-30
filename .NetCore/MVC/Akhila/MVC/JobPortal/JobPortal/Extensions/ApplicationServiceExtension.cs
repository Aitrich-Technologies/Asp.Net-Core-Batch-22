using JobPortal.Helper;
using JobPortal.Models;
using JobPortal.Repository;
using JobPortal.Service;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace JobPortal.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobPortalDbcontext>(options => options.
            UseSqlServer(config.GetConnectionString("Defaultconnection")));
            services.AddScoped<JobPortalService>();
            services.AddScoped<JobPortalRepository>();
            services.AddSession();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            return services;
        }
    }
}
