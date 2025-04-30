namespace _2DCinemaseat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] seats = { { 0,0,1,0,0},
            { 1,1,1,1,0},{0,1,1,0,0 } };
            for(int i=0;i<seats.GetLength(0);i++)
            {
                Console.WriteLine("\n");
                for (int j=0;j<5;j++)
                {
                    Console.Write(seats[i, j] + " ");
                }
               
            }
           
        }
    }
}
