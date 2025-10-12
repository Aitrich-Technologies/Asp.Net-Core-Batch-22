using AutoMapper;
using JobProviderBlazor.Dto;
using JobProviderBlazor.Model;
using Microsoft.EntityFrameworkCore;


namespace JobProviderBlazor.Repository
{
    public class JobProviderRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private JobProvider jobProvider=new JobProvider();
        private readonly IMapper _profile;
        private readonly ILogger<JobProviderRepository> Logger;
        public JobProviderRepository(ApplicationDBContext dbContext, IMapper mprofile,ILogger<JobProviderRepository> logger)
        {
            _dbContext = dbContext;
            _profile = mprofile;
            Logger = logger;
        }

        public async Task<string> ProviderRegistration(JobProviderDto provider)
        {
            jobProvider = _profile.Map<JobProvider>(provider);
            jobProvider.PasswordHash = BCrypt.Net.BCrypt.HashPassword(provider.Password);
            var isexists = _dbContext.JobProviders.FirstOrDefault(p => p.Email == jobProvider.Email);
            if (isexists == null)
            {
              // jobProvider =n
                    //_profile.Map<JobProvider>(provider);
                _dbContext.JobProviders.Add(jobProvider);
                await _dbContext.SaveChangesAsync();
               return "New user registered";
            }
            else
            {
                return "User already exists";
            }


        }

        public async Task<JobProviderDto> validateProvider(JobProviderDto provider)
        {
            jobProvider = _profile.Map<JobProvider>(provider);

            var registered = _dbContext.JobProviders
                .FirstOrDefault(p => p.Email == jobProvider.Email);

            if (registered != null && BCrypt.Net.BCrypt.Verify(provider.Password, registered.PasswordHash))
            {
                var providerlogin = _profile.Map<JobProviderDto>(registered);
                Logger.LogInformation("Id={Id}, Email={Email}", providerlogin.Id, providerlogin.Email);
                return providerlogin;
            }
            else
            {
                Logger.LogWarning("Login failed for email: {Email}", provider.Email);
                return null;
            }
        }

       
    }
}
