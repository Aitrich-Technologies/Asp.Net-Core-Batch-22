namespace billreciept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int burger = 120;
            int pizza = 250;
            int sandwitch = 100;
            int total;
            int i = 0;
            for(i=0;i<3;i++)
            { 
            Console.WriteLine("Enter the number of Burger ordered: ");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Pizza ordered: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Sandwitch ordered: ");
            int s = Convert.ToInt32(Console.ReadLine());
            total=(burger*b)+(pizza*p)+(sandwitch*s);
            Console.WriteLine("Total bill amount"+total+"\n");
            }
        }
    }
}
