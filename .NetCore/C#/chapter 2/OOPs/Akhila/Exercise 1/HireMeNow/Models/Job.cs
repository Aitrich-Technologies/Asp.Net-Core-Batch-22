using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireMeNow.Enums;

namespace HireMeNow.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevels ExperienceLevels { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }
        public int Status;

        public Job() { }
        public Job(int id, string title, ExperienceLevels experienceLevel, string company, string location, string salarayRange, string jobType, int status)
        {
            Id = id;
            Title = title;
            ExperienceLevels = experienceLevel;
            Company = company;
            Location = location;
            SalaryRange = salarayRange;
            JobType = jobType;
            Status = status;
        }
    }
}
