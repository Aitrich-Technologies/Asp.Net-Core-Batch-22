using JobPortal.Dto;
using JobPortal.Models;
using JobPortal.Repository;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Service
{
    
    public class JobPortalService
    {
        private readonly JobPortalRepository repository;
        public JobPortalService(JobPortalRepository _repository) 
            {
                repository = _repository;
            }
        public async Task AddJob(Job job)
        {
            await repository.AddJob(job);
        }
        public async Task<List<Job>> GetAllJobs()
        {
            return await repository.GetAllJobs();
        }
        public async Task<bool> registerUser(User user)
        {
            return await repository.registerUser(user);
        }
        public async Task<bool> VerifyUser(UserLoginDto userLogin)
        {
            return await repository.VerifyUser(userLogin);
        }
    }
}
