namespace JgDailytasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] dailytasks = new int[7][];
            dailytasks[0] = new int[] { 1, 2, 3 };
            dailytasks[1] = new int[] { 1, 2 };
            dailytasks[2] = new int[] { 1, 3 };
            dailytasks[3] = new int[] { 1, 2, 3 ,7};
            dailytasks[4] = new int[] { 2, 3 };
            dailytasks[5] = new int[] { 1};
            dailytasks[6] = new int[] { 1, 3 };
            for (int i = 0; i < dailytasks.Length; i++)
            {
                foreach (int task in dailytasks[i])
                {
                    Console.Write(task + "      ");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
