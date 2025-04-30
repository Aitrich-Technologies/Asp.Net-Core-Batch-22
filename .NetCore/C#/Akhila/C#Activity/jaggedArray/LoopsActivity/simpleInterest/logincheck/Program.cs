namespace logincheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "abc";
            string passwrd = "123";

            Console.WriteLine("Enter Username:");
            string login1 = Console.ReadLine();
               
            Console.WriteLine("Enter Password:");
            string password1 = Console.ReadLine();
               
            if (login1 == "abc" && password1 == "123")
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
