namespace simpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amt;
            double rate;
            double sinterest;
            int i=0;
            Console.WriteLine("Enter Amount:");
            amt=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate:");
            rate =Convert.ToDouble(Console.ReadLine());
           
            for( i=1;i<=3;i++)
            {
                sinterest = Convert.ToDouble(amt * rate * i) / 100;
                Console.WriteLine(" Year {0} Simple Interest is: {1}" ,i,sinterest);
            }
        }
    }
}
