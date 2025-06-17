using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop4_CollExcpLinq.Interfaces;
using Workshop4_CollExcpLinq.Models;

namespace Workshop4_CollExcpLinq.Manager
{
   public class UserManager:IMenu
    {
        private User loggedUser;
        JobManager jobManager = new JobManager();
        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public UserManager()
        {

        }

        public void DisplayMenu()
        {
            ShowJobSeekerMenu();
        }

        public void ShowJobSeekerMenu()
        {
            Console.WriteLine("1.List all Jobs\n2.My Profile\n3.Logout");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    jobManager.LisJobs();
                    ShowJobSeekerMenu();
                    break;
                case "2":
                    ShowJobSeekerMenu();
                    break;
                case "3":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid option entered");
                    ShowJobSeekerMenu();
                    break;
            }
        }


        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("You were successfully Logged out");
        }

        

    }
}
