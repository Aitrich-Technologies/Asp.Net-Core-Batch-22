namespace JgBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(0-2)savings, current, fixed deposits
            int[][] balance = new int[5][];
            balance[0] = new int[] { 10000, 25000, 50000 };
            balance[1] = new int[] { 20000, 5000 };
            balance[2] = new int[] { 10000, 25000, 150000 };
            balance[3] = new int[] { 2000, 34000 };
            balance[4] = new int[] { 25000, 200, 250000 };
            Console.WriteLine("Savings     Current   Fixed");
            for(int i=0;i<5;i++)
            {
                foreach (int typeacc in balance[i])
                {
                    Console.Write(typeacc + "      ");
                }
                 Console.WriteLine("\n");
            }    
            
        }
    }
}
