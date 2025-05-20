using JobProviderApplication.Managers;
using JobProviderApplication.Models;

namespace JobProviderApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobPortal jobPortal = new JobPortal();
            Printer printer = new Printer();
            int temp = 0;
            
            bool status = false;
            do
            {
                Console.WriteLine("Welcome to the JobProviderApplication Main Menu\nSelect the Option\n1.Jobs \t2.Applications\t 3.Interviews \t4.Print\t 5.Exit");
                string option = Console.ReadLine();
                do
                {
                    temp = 0;
                    
                    if (option == "1")
                    {
                        Console.WriteLine("Jobs Section:\n 1.Post Job\t 2.Get Jobs \t3.Back to Main Menu");
                        string optJob = Console.ReadLine();

                        if (optJob == "1")
                        {

                            Console.WriteLine("Enter the details of the Job.");
                            Console.WriteLine("Enter Job Id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Job Title:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter Job Description:");
                            string description = Console.ReadLine();
                            Console.WriteLine("Enter Job Location:");
                            string location = Console.ReadLine();
                            Console.WriteLine("Enter Job Salary:");
                            string salary = Console.ReadLine();
                            Console.WriteLine("Enter Job Type:");
                            string type = Console.ReadLine();
                            Console.WriteLine("Enter Job offering Company:");
                            string company = Console.ReadLine();

                            Job newJob = new Job(id, title, description, location, salary, type, company);
                            jobPortal.PostJob(newJob);
                        }

                        else if (optJob == "2")
                        {
                            jobPortal.GetJobs();
                        }

                        else 
                        { 
                                Console.WriteLine("Wrong Option!Back to Main Menu.");
                                status = true;
                                temp =1;                                
                        }


                    }
                    else if (option == "2")
                    {
                        Console.WriteLine("Applications Section: \n 1.Add Application\t 2.Get Application\t3.Back to Main Menu\n");
                        string optApp = Console.ReadLine();
                        if (optApp == "1")
                        {
                            Console.WriteLine("Enter details of application:");
                            Console.WriteLine("Enter Application ID:");
                            int appId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Application Name:");
                            string appName = Console.ReadLine();
                            Console.WriteLine("Enter Location:");
                            string appLoc = Console.ReadLine();
                            Console.WriteLine("Enter Qualification:");
                            string appQual = Console.ReadLine();
                            Console.WriteLine("Enter Experience:");
                            string appExp = Console.ReadLine();

                            Application newApp = new Application(appId, appName, appLoc, appQual, appExp);
                            jobPortal.AddApplication(newApp);
                        }
                        else if (optApp == "2")
                        {
                            jobPortal.GetApplications();
                        }
                        else 
                        {
                            Console.WriteLine("Wrong Option!Back to Main Menu.");
                            status = true;
                            temp = 1;
                        }
                        
                    }
                    else if (option == "3")
                    {
                        Console.WriteLine("Interview Section:\n 1.Schedule Interview\t 2.Get Interviews\t3.Back to Main Menu\n");
                        string optInterview = Console.ReadLine();
                        if (optInterview == "1")
                        {
                            Console.WriteLine("Enter the details of Interview:");
                            Console.WriteLine("Enter Interview Id:");
                            int inter_Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Company:");
                            string inter_Company = Console.ReadLine();
                            Console.WriteLine("Enter Post:");
                            string inter_Post = Console.ReadLine();
                            Console.WriteLine("Enter Date:");
                            string inter_Date = Console.ReadLine();
                            Console.WriteLine("Enter Location:");
                            string inter_Loc = Console.ReadLine();
                            Console.WriteLine("Enter Time:");
                            string inter_Time = Console.ReadLine();

                            Interview newInterview = new Interview(inter_Id, inter_Company, inter_Post, inter_Date, inter_Loc, inter_Time);
                            jobPortal.ScheduleInterview(newInterview);
                        }
                        else if (optInterview == "2")
                        {
                            jobPortal.GetInterviews();
                        }
                        else
                        {
                            Console.WriteLine("Wrong Option!Back to Main Menu.");
                            status = true;
                            temp = 1;

                        }
                        
                    }
                    else if(option=="4")
                    {
                        Console.WriteLine("Print Section:\n1.Print Jobs\t2.Print Applications\t3.Print Interview\t4.Back to Main Menu\n");
                        string optPrint= Console.ReadLine();
                        
                        
                        
                        switch(optPrint)
                        {
                            case "1":
                                Job[] jobs = jobPortal.GetJobs();
                                printer.Print(jobs);
                                break;
                            case "2":
                                Application[] applications = jobPortal.GetApplications();
                                printer.Print(applications); 
                                break;
                            case "3":
                                Interview[] interviews = jobPortal.GetInterviews();
                                printer.Print(interviews);
                                break;
                            case "4":
                                Console.WriteLine("Wrong Option!Back to Main Menu.");
                                status = true;
                                temp = 1;
                                break;
                        }
                        

                    }
                    else
                    {
                        temp = 1;
                        status = false;

                    }
                } while (temp == 0);

            } while (status == true);
        }
    }
}
