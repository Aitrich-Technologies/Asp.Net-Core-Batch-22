namespace JgStudentlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] stlist = new string[5][];
            stlist[0]=new string[] {"manu","anu","tanu","ram"};
            stlist[1] = new string[] { "manu", "anu", "tanu", };
            stlist[2] = new string[] { "tanu", "ram" ,"Om","Sam","don"};
            for(int i=0;i<stlist.Length;i++)
            {
                foreach (string name in stlist[i])
                {
                    Console.Write(name + "  ");
                }
                Console.WriteLine("\n");
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
