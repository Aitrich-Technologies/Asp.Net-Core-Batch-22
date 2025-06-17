
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop4_CollExcpLinq.Enums;
using Workshop4_CollExcpLinq.Interfaces;
using Workshop4_CollExcpLinq.Models;

namespace Workshop4_CollExcpLinq.Repository
{
    public class JobRepository : IJobRepository
        
    {
        public JobRepository()
        { }

        List<Jobs> jobs=new List<Jobs>()
        {
            new Jobs { Id = 1, Title = "Software Engineer", ExperienceLevel = ExperienceLevels.Senior, Company = "Acme Inc.", Location = "New York, NY", SalaryRange = "$100,000 - $150,000",JobType="Full Time" },
            new Jobs { Id = 2, Title = "Product Manager", ExperienceLevel = ExperienceLevels.MidLevel, Company = "Globex Corp.", Location = "San Francisco, CA", SalaryRange = "$120,000 - $180,000", JobType="Part Time" },
            new Jobs { Id = 3, Title = "Marketing Specialist", ExperienceLevel = ExperienceLevels.Fresher, Company = "Hooli Enterprises", Location = "Seattle, WA", SalaryRange = "$70,000 - $90,000",JobType="Intern" }
        };
        public List<Jobs> GetAllJobs()
        {
            return jobs;
        }
    }
}
