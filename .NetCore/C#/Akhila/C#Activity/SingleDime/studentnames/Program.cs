namespace studentnames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "abc", "bcv", "bcd", "xyz" };
            Console.WriteLine("Enter student's name: ");
            string sname = Console.ReadLine();
            foreach (string name in names)
            {
                if(sname == name)
                {
                    Console.WriteLine("The name is registered");
                    break;
                }
                else
                {
                    Console.WriteLine("The name is not registered");
                    break;
                }
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
