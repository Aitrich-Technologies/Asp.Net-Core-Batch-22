using Blazor_MachineTest.Helper;
using Blazor_MachineTest.Model;
using Blazor_MachineTest.Repository;
using Blazor_MachineTest.Services;
using Microsoft.EntityFrameworkCore;

namespace Blazor_MachineTest.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<PetServices>();
            services.AddScoped<PetRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
