using JobProviderBlazor.Repository;
using JobProviderBlazor.Helper;
using AutoMapper;
using JobProviderBlazor.Model;
using JobProviderBlazor.Dto;


namespace JobProviderBlazor.Service
{
    public class JobProviderService
    {
        private readonly JobProviderRepository _repository;
        private readonly IMapper _profile;
        private readonly ILogger<JobProviderService> Logger;
        
        public JobProviderService(JobProviderRepository repository, IMapper mprofile,ILogger<JobProviderService> logger)
        {
            _repository = repository;
            _profile = mprofile;
            Logger= logger;
        }
        public Task<string> ProviderRegistration(JobProviderDto provider)
        {
            return _repository.ProviderRegistration(provider);
        }

        public async Task<JobProviderDto> validateProvider(JobProviderDto provider)
        {
           
            var prov=await _repository.validateProvider(provider);
            Logger.LogInformation("Provider Id={Id} Email={Email}", prov.Id, prov.Email);
            return prov;
        }
      
    }
    
}
