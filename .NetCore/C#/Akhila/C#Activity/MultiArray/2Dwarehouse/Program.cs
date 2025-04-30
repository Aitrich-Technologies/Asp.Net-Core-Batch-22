namespace _2Dwarehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Stocks = { { 20 }, { 30 }, { 50 } };

            Console.WriteLine("Enter item to purchase(0-2):");
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sales count:");
            int count=Convert.ToInt32(Console.ReadLine());
         
            for(int i=0;i<=2;i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (i == item)
                    {
                        
                        Stocks[i, j] =Stocks[i,j]-count;
                        Console.WriteLine("Upadated stocks:{0}", Stocks[i, j]);
                    }
                }
            }
            //Console.WriteLine("Upadated stocks:");
            //for (int i=0;i<2; i++)
            //{
            //    Console.WriteLine("\n");
            //    for (int j=0;j<2;j++)
            //    {
            //        Console.WriteLine(Stocks[i, j] + " ");

            //    }
            //}
            Console.WriteLine("Hello, World!");
        }
    }
}
