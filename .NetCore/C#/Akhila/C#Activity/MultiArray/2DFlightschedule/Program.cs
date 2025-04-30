namespace _2DFlightschedule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] details = { { "F1997", "Mumbai","10:55PM" },
                                    { "F2997", "Kochi","8:55AM" },
                                    { "F3997", "Delhi","11:30PM" }};
            Console.WriteLine("Flight Schedule \n");
            for(int i = 0; i < 3;i++)
            {
               
                for(int j = 0; j < 3;j++)
                {
                    Console.Write(details[i,j] + "    ");
                }
                Console.WriteLine("\n");
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
