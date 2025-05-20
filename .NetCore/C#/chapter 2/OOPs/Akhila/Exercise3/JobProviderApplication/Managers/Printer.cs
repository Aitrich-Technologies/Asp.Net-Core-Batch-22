using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProviderApplication.Models;
using JobProviderApplication.Interface;

namespace JobProviderApplication.Managers
{
    public class Printer
    {
        public void Print(Job[] jobs) 
        {
            Console.WriteLine("\nPrint of all JOBS done:\n");
            //foreach (Job job in jobs)
            //{
            //    Console.WriteLine($"Job Tiltle:{job.Title}");
            //    Console.WriteLine($"Job Description:{job.Description}");
            //    Console.WriteLine($"Job Location:{job.Location}");
            //    Console.WriteLine($"Job Salary:{job.Salary}");
            //    Console.WriteLine($"Job Company:{job.Company}", job.Company);
            //}

        }


        public void Print(Application[] applications)
        {
            Console.WriteLine("\n\nPrint of all APPLICATIONS done:\n");
            //foreach (Application application in applications)
            //{

            //    Console.WriteLine($"Application Name:{application.Name}");
            //    Console.WriteLine($"Application Qualification:{application.Qualification}");
            //    Console.WriteLine($"Application Experience:{application.Experience}");

            //}

        }



        public void Print(Interview[] interviews)
        {
            Console.WriteLine("Print of all INTERVIEWS done:\n");
            //foreach(Interview interview in interviews)
            //{
            //    Console.WriteLine($"Company:{interview.Company}");
            //    Console.WriteLine($"Post:{interview.Post}");
            //    Console.WriteLine($"Date:{interview.Date}  Time:{interview.Time}");
            //    Console.WriteLine($"Location:{interview.Location}");
            //}

        }
    }
}
