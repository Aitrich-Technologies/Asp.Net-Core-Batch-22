namespace Admin_Job.Manager;

internal class Program
{
    static void Main(string[] args)
    {
        Admin admin=new Admin();
        Console.WriteLine("Welcome to the Job Portal Admin Module.");

        while (true)
        {
            Console.WriteLine("Please selct your option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    admin.Register();
                    break;
                case "2":
                    admin.Login();
                    break;
                case "3":
                    Console.WriteLine("You are Exiting now");
                    return;
                default:
                    Console.WriteLine("Invalid Option selected");
                    break;

            }
        }
    }
}
