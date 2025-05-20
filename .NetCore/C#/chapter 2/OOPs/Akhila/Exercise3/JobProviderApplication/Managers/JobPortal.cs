using JobProviderApplication.Models;
using JobProviderApplication.Interface;
using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JobProviderApplication.Managers
{
    public class JobPortal : IJobProvider, IApplicationProvider, IInterviewProvider
    {
        private int num_jobs = 0;
        private Job[] jobs = new Job[100];
        private int num_apps = 0;
        private Application[] applications=new Application[100];
        private int num_interview = 0;
        private Interview[] interviews= new Interview[100];


        //Implmenting IJobProvider
        public void PostJob(Job postjob)
        {
            
            if (num_jobs == jobs.Length)
            {
                Console.WriteLine("Maximum entry reached.Please try later");
                return;
            }
            //Console.WriteLine("Enter the details of the Job.");
            //Console.WriteLine("Enter Job Id:");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Job Title:");
            //string title = Console.ReadLine();
            //Console.WriteLine("Enter Job Description:");
            //string description = Console.ReadLine();
            //Console.WriteLine("Enter Job Location:");
            //string location = Console.ReadLine();
            //Console.WriteLine("Enter Job Salary:");
            //string salary = Console.ReadLine();
            //Console.WriteLine("Enter Job Type:");
            //string type = Console.ReadLine();
            //Console.WriteLine("Enter Job offering Company:");
            //string company = Console.ReadLine();

            //Job newJob = new Job(id, title, description, location, salary, type, company);

            jobs[num_jobs] = postjob;
            num_jobs++;
        }


        public Job[] GetJobs()
        {
            Console.WriteLine("List of Jobs:");

            for(int i=0;i<num_jobs;i++)
            {
                Console.WriteLine($"Job Title:{jobs[i].Title}");
                Console.WriteLine($"Job Description:{jobs[i].Description}");
                Console.WriteLine($"Job Location:{jobs[i].Location}");
                Console.WriteLine($"Job Salary:{jobs[i].Salary}");
                Console.WriteLine($"Job Type:{jobs[i].Type}");
                Console.WriteLine($"Company:{jobs[i].Company}");
            }
            return jobs;
        }

        //Implmenting IApplicationProvider
        public void AddApplication(Application addApplication)
        {
            if(num_apps==applications.Length)
            {
                Console.WriteLine("Maximum Limit Reached.Try Later.");
                return;
            }
            //Console.WriteLine("Enter details of application:"); 
            //Console.WriteLine("Enter Application ID:");
            //int appId=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Application Name:");
            //string appName=Console.ReadLine();
            //Console.WriteLine("Enter Location:");
            //string appLoc=Console.ReadLine();
            //Console.WriteLine("Enter Qualification:");
            //string appQual=Console.ReadLine();
            //Console.WriteLine("Enter Experience:");
            //string appExp=Console.ReadLine();

            //Application newApp = new Application(appId, appName, appLoc, appQual, appExp);
            applications[num_apps]= addApplication;

            num_apps++;


        }

        

        public Application[] GetApplications()
        {
            Console.WriteLine("List of Applications:");

            for(int i=0;i<num_apps;i++)
            {
                Console.WriteLine($"Application Name:{applications[i].Name}");
                Console.WriteLine($"Application Location:{applications[i].Location}");
                Console.WriteLine($"Application Qualification:{applications[i].Qualification}");
                Console.WriteLine($"Application Experience:{applications[i].Experience}");
            }
            return applications;
        }



        //Implmenting IInterviewProvider
        public void ScheduleInterview(Interview schInterview)
        {
            if (num_interview == interviews.Length)
            {
                Console.WriteLine("Maximum Limit reached.");
                return;
            }
            //Console.WriteLine("Enter the details of Interview:");
            //Console.WriteLine("Enter Interview Id:");
            //int inter_Id=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Company:");
            //string inter_Company=Console.ReadLine();
            //Console.WriteLine("Enter Post:");
            //string inter_Post=Console.ReadLine() ;
            //Console.WriteLine("Enter Date:");
            //string inter_Date = Console.ReadLine();
            //Console.WriteLine("Enter Location:");
            //string inter_Loc=Console.ReadLine();
            //Console.WriteLine("Enter Time:");
            //string inter_Time=Console.ReadLine();

            //Interview newInterview = new Interview(inter_Id, inter_Company, inter_Post, inter_Date, inter_Loc, inter_Time);
            interviews[num_interview] = schInterview;

            num_interview++;
        }

        public Interview[] GetInterviews()
        {
            Console.WriteLine("Interview Details:");
            for (int i = 0; i < num_interview; i++)
            {
                Console.WriteLine($"Company Name:{interviews[i].Company}");
                Console.WriteLine($"Name of Post:{interviews[i].Post}");
                Console.WriteLine($"Interview Date:{interviews[i].Date}");
                Console.WriteLine($"Interview Location:{interviews[i].Location}");
                Console.WriteLine($"Interview Time:{interviews[i].Time}");

            }
            return interviews;
        }
    }
}
