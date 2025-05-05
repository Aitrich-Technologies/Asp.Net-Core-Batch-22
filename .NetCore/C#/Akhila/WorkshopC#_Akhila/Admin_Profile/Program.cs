namespace Admin_Profile
{
    internal class Program
    {
        struct AdminProfile
        {
            public string name;
            public string username;
            public string email;
            public int phno;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------Welcome to Admin Profile------------------------------------------------------");
            AdminProfile[] admin = new AdminProfile[1];
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            string ch;
            do
            {
                Console.WriteLine("A-Register as Admin--------------------------------------------------------------------------------------------");
                Console.WriteLine("D-Displsy Admin Details----------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Select an option from list-------------------------------------------------------------------------------------");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "A":
                        {
                            Console.WriteLine("----------------------------------------------------------Admin Registration-------------------------------------------------------");
                            Console.WriteLine("Enter name of Admin : ");
                            admin[0].name = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter the username of an admin: ");
                            admin[0].username = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter an E-mail of an admin: ");
                            admin[0].email = Console.ReadLine();
                            Console.WriteLine("\n");
                            Console.WriteLine("Enter Phone number of an admin: ");
                            admin[0].phno = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                            break;
                        }
                    case "D":
                        {
                            Console.WriteLine("-----------------------------------------------------------Admin Details-----------------------------------------------------------");
                            Console.WriteLine("Name of Admin: {0}", admin[0].name);
                            Console.WriteLine("Username of Admin: {0}", admin[0].username);
                            Console.WriteLine("E-mail of Admin: {0}", admin[0].email);
                            Console.WriteLine("Phone number of Admin: {0}", admin[0].phno);
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------");
                            break;
                        }


                }
                Console.WriteLine("Do you want to continue(Y/N) ? ");
                ch = Console.ReadLine();


            }
            while (ch == "Y" || ch == "y");
                    
        }
    }
}
