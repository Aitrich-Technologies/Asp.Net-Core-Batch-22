namespace passwordattempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "123";
            int i;
            Console.WriteLine("Enter Correct Password:");
            for (i = 0; i <= 2; i++)
            {

                string password1 = Convert.ToString(Console.ReadLine());
                if (password1 == password && i <= 2)
                {
                    Console.WriteLine("Access Granted");
                    break;
                }
                else if (i <2)
                {
                    Console.WriteLine("Enter Correct Password:");

                }
                else
                {
                    Console.WriteLine("Access Locked");
                }
            }
        }
    }
}
