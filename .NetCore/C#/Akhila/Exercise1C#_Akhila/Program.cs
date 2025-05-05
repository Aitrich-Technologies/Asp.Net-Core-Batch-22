using System.Runtime;
using System.Runtime.InteropServices;

namespace C__Exercise1
{
    internal class Program
    {
        public struct User
        {
            public string name;
            public string email;
            public string password;
            public User(string n,string e,string p)
            {
                name = n;
                email = e;
                password = p;
            }
            public void view()
            {
                Console.WriteLine("My name is {0} \n Username {1}", name, email);
            }
        }
        public struct Jobs
        {
            public int ID;
            public string Title;
            public int Experience;
            public string Company;
            public string Location;
            public int Salary;

            public Jobs(int id,string title,int exp,string comp,string loc,int sal)
            {
                ID= id;
                Title= title;   
                Experience= exp;
                Company= comp;
                Location= loc;
                Salary= sal;

            }
            public void display()
            {
                Console.WriteLine(ID+ "\t" + Title + "\t" + Experience + "\t\t" +Company + "\t" + Location + "\t\t" + Salary);
            }
        }
        //public string nam;
        static void Main(string[] args)
        {
            Jobs[] jobs = [new Jobs(1, "HR", 3, "TATA", "PUNE", 5000000), new Jobs(2, "CA", 5, "DELL", "MUMBAI", 555000)];
            User[] users = new User[1];
            Console.WriteLine("----------Welcome to the Job Seeker Portal------------------");
            int choice;
            int temp = 1;
            int option;
            string nam = "";
            string e_mail1 = "";
            string pawd1 = "";
            
            do
            {
                Console.WriteLine("-----------------Welcome to the Job Portal------------------");
                Console.WriteLine("-----1----Register");
                Console.WriteLine("-----2----Login   ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Please Enter your Name:");
                    nam = Console.ReadLine();
                    Console.WriteLine("Please Enter your E-mail:");
                    e_mail1 = Console.ReadLine();
                    Console.WriteLine("Please Enter your Password:");
                    pawd1 = Console.ReadLine();
                    new User(nam, e_mail1, pawd1);
                    Console.WriteLine("REGISTRATION SUCCESSFUL !");
                }
                else
                {
                    
                    Console.WriteLine("Please Enter your E-mail:");
                    string e_mail = Console.ReadLine();
                    Console.WriteLine("Please Enter your Password:");
                    string pawd = Console.ReadLine();
                    if (e_mail1 == e_mail && pawd1 == pawd)
                    {

                        Console.WriteLine("LOGIN SUCCESSFUL !");
                        do
                        {
                            Console.WriteLine("------------------Welcome {0}-----------------", nam);
                            Console.WriteLine("-----------1------------List all Jobs-----");
                            Console.WriteLine("-----------2------------My Profile________");
                            Console.WriteLine("-----------3------------Logout------------");
                            option = Convert.ToInt32(Console.ReadLine());

                            switch (option)

                            {
                                case 1:
                                    Console.WriteLine("ID" + "\t" + "TITLE" + "\t" + "EXPERIENCE" + "\t" + "COMPANY" + "\t" + "LOCATION" + "\t" + "SALARY");
                                    jobs[0].display();
                                    jobs[1].display();
                                    break;
                                case 2:
                                    Console.WriteLine("----------------MY PROFILE-------------------- ");
                                    //User[] users = new User[1];
                                    users[0] = new User(nam, e_mail, pawd);
                                    users[0].view();
                                    break;
                                case 3:
                                    Console.WriteLine("--------------LOGOUT SUCCESSFULLY--------------");
                                    temp = 0;
                                    break;

                            }

                        } while (temp == 1);
                    }
                    else
                    {
                        Console.Write("LOGIN FAILED");
                        temp = 1;
                    }
                    
                                      
                }
            } while (temp == 1);

        }
    }
}
