using AutoMapper;
using Exercise_MVC.Dto;
using Exercise_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Exercise_MVC.AppRepository
{
    public class ApplicationRepository
    {
        private readonly ApplicationDBContext context;
        private readonly IMapper mapper;
        public ApplicationRepository(ApplicationDBContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public async Task<bool> registerUser(User user)
        {
            var registereduser = await context.Users.SingleOrDefaultAsync(u => u.Email == user.Email);
            if (registereduser == null)
            {
                context.Users.Add(user);
                await context.SaveChangesAsync();
                return true;

            }
            return false;
        }
        public async Task<bool> VerifyUser(Login_Dto userlogin)
        {
            if (await context.Users.FirstOrDefaultAsync(u => u.Email == userlogin.Email && u.Password == userlogin.Password) == null)
            {
                return false;
            }
            return true;
        }
        public async Task<User> GetUserID(Login_Dto userlogin)
        {
           var userid=mapper.Map<User>(userlogin);
           var edituser=await context.Users.SingleOrDefaultAsync(u=>u.Id==userid.Id);
            return edituser;
            
        }
        public async Task<User> UpdateUser(string mail)
        {
            var updateuser = await context.Users.SingleOrDefaultAsync(u=>u.Email==mail);
            return updateuser;
        }

        public async Task UpdateDetails(User user)
        {
            var existing = await context.Users.FindAsync(user.Id);
            existing.Aboutme = user.Aboutme;
            existing.Education = user.Education;
            existing.Skills = user.Skills;
            existing.Experience = user.Experience;
            await context.SaveChangesAsync();
        }
        //Job
        public async Task<List<Job>> GetAllJobs()
        {
            var alljobs = context.Jobs.ToList();
            return alljobs;
        }
        public async Task<Job> GetJobID(int id)
        {
            var job= context.Jobs.SingleOrDefault(j => j.ID == id);
            return job;
            
        }
        public async Task<bool> JobVerify(Job job)
        {
            var registeredjob = await context.Jobs.SingleOrDefaultAsync(j => j.Title == job.Title && j.Description==job.Description);
            if (registeredjob == null)
            {
                context.Jobs.Add(job);
                await context.SaveChangesAsync();
                return true;

            }
            return false;
        }
    }

}
