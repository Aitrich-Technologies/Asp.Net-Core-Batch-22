namespace templogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temps = {  96.7, 99, 95, 102.5, 99.5, 96, 100 };
           
            double smallest = temps[0];
            double largest = temps[6];
            foreach (double value in temps)
            {
                if (value < smallest)
                {
                    smallest = value;
                }
                if (value > largest)
                {
                    largest = value;
                }
            }

             Console.WriteLine("lowest temperature is :" + smallest);
             Console.WriteLine(" Highest temperature is :" + largest);
        }
    }
}
