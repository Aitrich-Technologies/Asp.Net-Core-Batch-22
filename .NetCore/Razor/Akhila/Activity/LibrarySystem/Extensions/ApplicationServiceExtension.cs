using LibrarySystem.Helper;
using LibrarySystem.Model;
using LibrarySystem.Repository;
using LibrarySystem.Services;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<LibraryServices>();
            services.AddScoped<LibraryRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddSession();
            services.AddHttpContextAccessor();
            return services;
        }
    }
}
