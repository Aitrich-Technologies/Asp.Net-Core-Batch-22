namespace enumIteration
{
    internal class Program
    {
       enum  Days { Mon, Tue, Wed, Thu, Fri, Sat, Sun };
        static void Main(string[] args)
        {
            foreach (Days day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(day);
            }
        }
    }
}
