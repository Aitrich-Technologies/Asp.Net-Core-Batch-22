using Admin_Job.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Manager
{
    internal class Admin
    {
        private User[] users = new User[2];
        private int num_users = 0;
        JobManager Job = new JobManager();
        bool is_logged = false;
        public void Register()
        {
            Console.WriteLine("Enter Username:");
            string regUsername=Console.ReadLine();
            Console.WriteLine("Emter Password:");
            string regPassword=Console.ReadLine() ;
            if (num_users == users.Length)
            {
                Console.WriteLine("Maximum number of users reached. Please try again later.");
                return;
            }

            User newuUser=new User(regUsername,regPassword);
            users[num_users] = newuUser;
            num_users++;

            Console.WriteLine("Registration Successful");

        }


        public bool Login()
        {
            Console.Write("Enter username: ");
            string loginUsername = Console.ReadLine();

            Console.Write("Enter password: ");
            string loginPassword = Console.ReadLine();

            for (int i = 0; i < num_users; i++)
            {
                if (users[i].Username == loginUsername && users[i].Password == loginPassword)
                {
                    Console.WriteLine("Login Successfull.");
                    is_logged = true;
                    string ch = "0";
                    if (is_logged)

                        while (ch != "3")
                        {
                            Console.WriteLine("1. Post Job \n");
                            Console.WriteLine("2. List Jobs \n");
                            Console.WriteLine("3. Main Menu \n");
                            ch = Console.ReadLine();
                            switch(ch)
                            {
                                case "1":
                                    Job.AddJob();
                                    break;
                                case "2":
                                    Job.ListJob(); 
                                    break;
                                case "3":
                                    Console.WriteLine("Exit");
                                    break;

                            }
                            //if (ch == "1")
                            //{
                            //    Job.AddJob();
                            //}
                            //if (ch == "2")
                            //{
                            //    Job.ListJob();
                            //}
                            //if (ch == "3")
                            //{
                            //    Console.WriteLine("Exit");

                            //}

                        }
                    return true;
                }
                
              
            }
            Console.WriteLine("Invalid User or Wrong Password!");
            return false;

        }
    }
}
