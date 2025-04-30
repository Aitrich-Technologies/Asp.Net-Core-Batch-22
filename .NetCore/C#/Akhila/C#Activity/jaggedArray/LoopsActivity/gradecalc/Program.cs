namespace gradecalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student marks:");
            int marks = Convert.ToInt32(Console.ReadLine());
            if (marks >= 90)
            {
                Console.WriteLine("Grade is A");
            }
            else if ((marks >= 80) && (marks <= 89))
            {
                Console.WriteLine("Grade is B");
            }
            else if ((marks >= 70) && (marks <= 79))
            {
                Console.WriteLine("Grade is C");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        } 
    }
}
