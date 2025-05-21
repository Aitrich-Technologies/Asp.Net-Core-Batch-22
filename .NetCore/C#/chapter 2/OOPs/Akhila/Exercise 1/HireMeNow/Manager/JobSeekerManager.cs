using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using HireMeNow.Interface;
using HireMeNow.Models;
using HireMeNow.Enums;

namespace HireMeNow.Manager
{
    public class JobSeekerManager:IAppliedJobs
    {
        private JobSeeker[] jobSeekers=new JobSeeker[10];
         JobManager jobManager=new JobManager();
        private int num_seekers = 0;
        private Job jobs=new Job();
        
        
        
        public void RegisterJobSeeker(string userName,string password)
        {
            //Console.WriteLine("Enter Email Id:");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Enter Password:");
            //string password=Console.ReadLine();
            jobSeekers[num_seekers]= new JobSeeker(userName, password);
            num_seekers++;
            return;
        }

        public void LoginJobSeeker()
        {
            Console.WriteLine("Enter Email Id:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            int id = 1;
            foreach (JobSeeker jobSeeker in jobSeekers)
            {
                if ((userName == jobSeeker.Email) && (password == jobSeeker.Password))
                {
                    Console.WriteLine("You are Successfully LoggedIn");
                    Console.WriteLine("Welcome to HireMeNow!");
                    Console.WriteLine("Enter your Profile Details:");
                    jobSeeker.Id = id;
                    Console.WriteLine("FirstName:");
                    jobSeeker.FirstName=Console.ReadLine();
                    Console.WriteLine("LastName:");
                    jobSeeker.LastName = Console.ReadLine();
                    Console.WriteLine("Phone Number:");
                    jobSeeker.Phone= Console.ReadLine();
                    Console.WriteLine("Location:");
                    jobSeeker.Location = Console.ReadLine();
                    Console.WriteLine("About Me:");
                    jobSeeker.AboutMe = Console.ReadLine();
                    Console.WriteLine("Qualification:");
                    jobSeeker.Qualification= Console.ReadLine();
                    //jobSeeker.ExperienceLevel  = ExperienceLevels.Fresher;
                    //Console.WriteLine("Enter Experience Level(Fresher/Mid Level/Senior):");
                    //string level = Console.ReadLine();
                    //jobSeeker.ExperienceLevel = (ExperienceLevels)Enum.Parse(typeof(ExperienceLevels).level);

                    id++;
                    break;
                }
                else
                {
                    Console.WriteLine("You are not yet Registered.Please Register Now!");
                   
                }
            }
            return;
        }


        public void ViewProfile(string email, string password)
        {
            foreach (JobSeeker jobSeeker in jobSeekers)
            {
                if ((email == jobSeeker.Email) && (password == jobSeeker.Password))
                {
                    Console.WriteLine($"Hi,{jobSeeker.FirstName}");
                    Console.WriteLine($"Email:{jobSeeker.Email}\nPhone:{jobSeeker.Phone}\nLocation:{jobSeeker.Location}\n\tAbout Me:{jobSeeker.AboutMe}\nQualification{jobSeeker.Qualification}\n");
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong username or Password!");
                }
            }
            return;
        }



        //Implemention of IAppliedJobs
        public void addAppliedJobs(int jobid)
        {
            foreach (Job job in jobManager.jobs)
            {
                if (jobid==job.Id)
                {
                    Console.WriteLine($"You are Applied for Job Id:{job.Id}");
                    job.Status = 1;
                    return;
                }
                
            }
           
                Console.WriteLine("Wrong Job ID");

           
            return;
        }



        public void getAppliedJobs()
        {
            foreach(Job job in jobManager.jobs)
            {
                if(job.Status==1)
                {
                    Console.WriteLine($"Applied Jobs:\nJob Id:{job.Id}\nJob Title:{job.Title}\nCompany:{job.Company}\nJob  Salary:{job.SalaryRange}\nJob Type:{job.JobType}");
                }
            }
            return;
        }
    }
}
