using HireMeNow.Models;
using HireMeNow.Manager;
using HireMeNow.Interface;
using HireMeNow.Enums;

namespace HireMeNow
{
    public class Program
    {
        static void Main(string[] args)
        {
            JobSeekerManager newSeeker = new JobSeekerManager();
            JobSeeker Seeker=new JobSeeker();

            JobManager jobManager = new JobManager();
            //Job job = new Job();

            int temp=0;
            do
            {
                Console.WriteLine("Welcome to the Hire Me Now Job Portal System\n1.Register\t2.Login\t3.Exit");
                string option = Console.ReadLine();
                
                if (option == "1")
                {
                    Console.WriteLine("Enter Email Id:");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Enter Password:");
                    string password = Console.ReadLine();
                    newSeeker.RegisterJobSeeker(userName,password);
                   
                }
                else if (option == "2")
                {
                    newSeeker.LoginJobSeeker();
                    int seek=0;
                    do
                    {
                        Console.WriteLine("Welcome.\n1.View Jobs\t2.View Profile\t3.Apply for Job \t4.Saved Jobs(Applied JOBS)\t5.Exit");
                        string seekerOpt = Console.ReadLine();
                        switch (seekerOpt)
                        {
                            case "1":
                                jobManager.ListJobs();
                                break;
                            case "2":
                                Console.WriteLine("Enter Email Id:");
                                string userName = Console.ReadLine();
                                Console.WriteLine("Enter Password:");
                                string password = Console.ReadLine();
                                newSeeker.ViewProfile(userName, password);
                                break;
                            case "3":
                                jobManager.ListJobs();
                                Console.WriteLine("Enter Job Id");
                                int jobId = Convert.ToInt32(Console.ReadLine());
                                newSeeker.addAppliedJobs(jobId);
                                break;
                            case "4":
                                newSeeker.getAppliedJobs();
                                break;
                            case "5":
                                Console.WriteLine("Exit");
                                seek = 1;
                                break;
                        }
                    } while (seek == 0);
                }
                else
                {
                    Console.WriteLine("Exit");
                    temp = 1;
                }
            } while(temp==0);
        }
    }
}
