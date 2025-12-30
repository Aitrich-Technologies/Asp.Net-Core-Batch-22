using AutoMapper;
using JobPortal.Dto;
using JobPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repository
{
    public class JobPortalRepository
    {
        public readonly JobPortalDbcontext dbcontext;
        private readonly IMapper mapper;
        public JobPortalRepository(JobPortalDbcontext _dbcontext,IMapper _mapper)
        {
            dbcontext = _dbcontext;
            mapper = _mapper;
        }

        //Job
        public async Task AddJob(Job job)
        {
            dbcontext.Jobs.Add(job);
            await dbcontext.SaveChangesAsync();
        }
        public async Task<List<Job>> GetAllJobs()
        {
            var alljobs = dbcontext.Jobs.ToList();
            return alljobs;
        }


        //USER
        public async Task<bool> registerUser(User user)
        {
            var registereduser =await dbcontext.Users.SingleOrDefaultAsync(u => u.Email == user.Email);
            if (registereduser==null) 
                {
                    dbcontext.Users.Add(user);
                    await dbcontext.SaveChangesAsync();
                    return true;
                }
            return false;
        }
        public async Task<bool> VerifyUser(UserLoginDto userLogin)
        {
            var user = mapper.Map<User>(userLogin);
            if (await dbcontext.Users.FirstOrDefaultAsync(u => u.Email == user.Email && u.Password == user.Password) == null)
            {
                return false;
            }
            return true;
        }
    }
}
