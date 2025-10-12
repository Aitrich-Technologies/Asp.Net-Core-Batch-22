using Exercise_Blazor.Model;
using ExerciseBlazor.Migrations;

using Microsoft.EntityFrameworkCore;
namespace Exercise_Blazor.Repository
{
    public class JobDetailsRepository
    {
        private readonly ApplicationDBContext _dbContext;
        

        //public List<JobDetails> ListJobs= new List<JobDetails>();
        public JobDetailsRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task JobRegistraton(JobDetail newJob)

        {
            _dbContext.JobDetails.Add(newJob);
            
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<JobDetail>> GetAllJobsAsync()
        {
            return await _dbContext.JobDetails.ToListAsync();
        }

        public async Task RemoveJobbyIdAsync(int jobid)
        {
            var job = await _dbContext.JobDetails.SingleOrDefaultAsync(j => j.Id == jobid);
            if (job != null)
            {
                _dbContext.JobDetails.Remove(job);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
