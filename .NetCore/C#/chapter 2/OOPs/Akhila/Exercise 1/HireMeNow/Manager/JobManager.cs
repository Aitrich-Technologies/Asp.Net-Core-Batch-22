using HireMeNow.Models;
using HireMeNow.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireMeNow.Interface;

namespace HireMeNow.Manager
{
    public class JobManager
    {
        public Job[] jobs = new Job[]{new Job(1, "SE",ExperienceLevels.Fresher,"Dell","Pune","25k","Programmer",0),
                              new Job(2,"WebDeveloper",ExperienceLevels.MidLEvel,"Accenture","Kochi","35k","Developer",0),
                               new Job(3,"WebDeveloper",ExperienceLevels.MidLEvel,"Accenture","Kochi","35k","Developer", 0),
                               new Job(4, "SE",ExperienceLevels.Fresher,"Dell","Pune","25k","Programmer", 0),
                              new Job(5,"WebDeveloper",ExperienceLevels.MidLEvel,"E&Y","Kochi","35k","Developer", 0),
                               new Job(6,"WebDeveloper",ExperienceLevels.MidLEvel,"Accenture","Kochi","35k","Developer", 0),
                               new Job(7, "SE",ExperienceLevels.Fresher,"Dell","Pune","25k","Programmer", 0),
                              new Job(8,"WebDeveloper",ExperienceLevels.MidLEvel,"TCS","Kochi","35k","Developer", 0),
                               new Job(9,"WebDeveloper",ExperienceLevels.MidLEvel,"Accenture","Kochi","35k","Developer", 0),
                               new Job(10,"Backend Developer",ExperienceLevels.Senior,"Infosys","TVM","50k","Developer", 0)

        };


        //Methods
        public void ListJobs()
        {
            Console.WriteLine("List of Available Jobs:");
            for (int i = 0; i < jobs.Length; i++)
            {
                Console.WriteLine($"JobId:{jobs[i].Id}   Title:{jobs[i].Title}   Exp.Level:{jobs[i].ExperienceLevels.ToString()}   Company:{jobs[i].Company}   Location:{jobs[i].Location}   SalaryRange:{jobs[i].SalaryRange}   JobType:{jobs[i].JobType}");
            }
        }


        public void GetJobbyId(int id)
        {
            foreach(Job job in jobs)
            {
                if(job.Id == id)
                {
                    Console.WriteLine($"Details of job:\nJobTitle:{job.Title}\nCompany:{job.Company}\nJob Location:{job.Location}\n Salary:{job.SalaryRange}");
                }
                
            }
        }



    }
}
