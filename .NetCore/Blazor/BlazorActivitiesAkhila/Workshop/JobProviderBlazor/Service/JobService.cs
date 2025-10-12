using JobProviderBlazor.Repository;
using JobProviderBlazor.Helper;
using AutoMapper;
using JobProviderBlazor.Model;
using JobProviderBlazor.Dto;
using System.ComponentModel;


namespace JobProviderBlazor.Service
{
    public class JobService
    {
        private readonly JobRepository _repository;
        private readonly IMapper _profile;

        public JobService(JobRepository repository, IMapper mprofile)
        {
            _repository = repository;
            _profile = mprofile;
        }
        public async Task<List<JobDto>> GetAllJobs()
        {
            return await _repository.GetAllJobsAsync();
        }
        public async Task AddJob(JobDto newjob,int id)
        {
            await _repository.AddJob(newjob,id);
        }
    }
}
