using Microsoft.EntityFrameworkCore;
using Exercise_Blazor.Repository;
using Exercise_Blazor.Model;

namespace Exercise_Blazor.Services
{
    public class JobDetailServices
    {

        private readonly JobDetailsRepository _jobRepository;
        public JobDetailServices(JobDetailsRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task JobRegistraton(JobDetail newJob)
        {
            await _jobRepository.JobRegistraton(newJob);
        }

        public async Task<List<JobDetail>> GetAllJobsAsync()
        {
            return await _jobRepository.GetAllJobsAsync();
        }
        public async Task RemoveJobbyIdAsync(int jobid)
        {
            await _jobRepository.RemoveJobbyIdAsync(jobid);
        }
    }
}
