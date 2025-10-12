using AutoMapper;
using JobProviderBlazor.Dto;
using JobProviderBlazor.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProviderBlazor.Repository
{
    public class JobRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _profile;
        List<Job> jobs=new List<Job>();
        Job job = new Job();
        public JobRepository(ApplicationDBContext dbContext, IMapper mprofile)
        {
            _dbContext = dbContext;
            _profile = mprofile;
        }
        public async Task<List<JobDto>> GetAllJobsAsync()
        {
            //return await _repository.GetAllJobs();
            jobs=await _dbContext.Jobs.ToListAsync();

            return _profile.Map<List<JobDto>>(jobs);
        }

        public async Task AddJob(JobDto newjob, int id)
        {
            job = _profile.Map<Job>(newjob);
            job.JobProviderId = id;
            _dbContext.Jobs.Add(job);
            await _dbContext.SaveChangesAsync();
        }
       
    }
}
