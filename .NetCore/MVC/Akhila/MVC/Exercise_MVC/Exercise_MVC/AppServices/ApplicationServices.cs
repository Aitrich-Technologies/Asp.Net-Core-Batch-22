using Exercise_MVC.AppRepository;
using Exercise_MVC.Dto;
using Exercise_MVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace Exercise_MVC.AppServices
{
    public class ApplicationServices
    {
        private readonly ApplicationRepository repository;
        public ApplicationServices(ApplicationRepository _repository)
        {
            repository= _repository;
        }
        public async Task<bool> registerUser(User user)
        {
            return await repository.registerUser(user);

        }
        public async Task<bool> VerifyUser(Login_Dto userlogin)
        {
            return await repository.VerifyUser(userlogin);
        }
        public async Task<User> GetUserID(Login_Dto userlogin)
        {
            return await repository.GetUserID(userlogin);
        }
        public async Task<User> UpdateUser(string mail)
        {
            return await repository.UpdateUser(mail);
            
        }
        public async Task UpdateDetails(User user)
        {
            await repository.UpdateDetails(user);
        }

        //Job
        public async Task<List<Job>> GetAllJobs()
        {
            return await repository.GetAllJobs();
        }
        //public async Task<Job> GetJobID(int id)
        //{
        //    return await repository.GetJobID(id);
        //}
        public async Task<bool> JobVerify(Job job)
        {
            return await repository.JobVerify(job);
        }
    }
}
