namespace OddorEvenDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date (1–31):");
            int date=Convert.ToInt32(Console.ReadLine());
            if (date % 2 == 0)
            {
                Console.WriteLine("It is an Even date");
            }
            else
            {
                Console.WriteLine("It is an Odd date");
            }
        }
    }
}
