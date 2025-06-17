using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop4_CollExcpLinq.Models;
using Workshop4_CollExcpLinq.Repository;

namespace Workshop4_CollExcpLinq.Manager
{
    public class JobManager
    {
        JobRepository jobRepository = new JobRepository();

        public void LisJobs()
        {
            Console.WriteLine("Jobs available: \nJobId\tTitle\tExperienceLevel\tCompany\tLocation\tSalaryRange\tJobType");
            List<Jobs> jobs=jobRepository.GetAllJobs();
            foreach(Jobs job in jobs)
            {
                Console.WriteLine($"{job.Id}\t{job.Title}\t{job.ExperienceLevel}\t{job.Company}\t{job.Location}\t{job.SalaryRange}\t{job.JobType}");

            }
            Console.WriteLine("\n");
        }
    }
}
