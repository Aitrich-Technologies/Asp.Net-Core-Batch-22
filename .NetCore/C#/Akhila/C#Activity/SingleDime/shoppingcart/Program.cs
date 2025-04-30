namespace shoppingcart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] price= { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int total=0;
            int i;
            for(i=0;i<10;i++)
            {
                total+=price[i];
            }
            Console.WriteLine("Total bill amount is {0}",total);
        }
    }
}
