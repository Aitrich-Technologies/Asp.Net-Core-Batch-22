namespace JgRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(0-2)starters, main course, desserts
            int[][] items = new int[3][];
            items[0] = new int[] { 1,2,3,4};
            items[1] = new int[] {1,2,3 };
            items[2] = new int[] {1,2,3,4,5 };
            
            Console.WriteLine("Startesr   Main   Desserts");
            for (int i = 0; i < 3; i++)
            {
                foreach (int itemcount in items[i])
                {
                    Console.Write(itemcount + "           ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
