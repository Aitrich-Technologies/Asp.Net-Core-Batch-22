using Admin_Job.Interface;
using Admin_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Admin_Job.Manager
{
    public  class JobManager:IJob
    {

        private int numJobs = 0;
        private Job[] jobs = new Job[100];
        public void AddJob()
        {
            if(numJobs == jobs.Length)
            {
                Console.WriteLine("MAximum number of jobs reached.Please try later");
                return;
            }
            Console.WriteLine("Enter Job Id:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eneter Job Title:");
            string title=Console.ReadLine();
            Console.WriteLine("Enter Job Description:");
            string description=Console.ReadLine();
            Console.WriteLine("Enter Job Salary:");
            string salary=Console.ReadLine();
            Console.WriteLine("Enter Job Location:");
            string location=Console.ReadLine();
            Job newJob=new Job(id,title,description,salary,location);
            
            jobs[numJobs] = newJob;
            numJobs++;

            Console.WriteLine("Job added Successfully.");

        }

        public void ListJob()
        {
            Console.WriteLine("Jobs:");
            for (int i = 0; i < numJobs; i++)
            {
                Console.WriteLine($"Title: {jobs[i].title}");
                Console.WriteLine($"Description: {jobs[i].description}");
                Console.WriteLine($"Salary: {jobs[i].salary}");
                Console.WriteLine($"Location: {jobs[i].location}");
            }
        }
    }
}
