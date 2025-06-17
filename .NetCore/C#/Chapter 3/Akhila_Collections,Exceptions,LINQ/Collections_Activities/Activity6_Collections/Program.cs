using System.Collections;
namespace Activity6_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList my_aarray = new ArrayList();
            my_aarray.Add(1);
            my_aarray.Add(true);
            my_aarray.Add("atul");
            my_aarray.Add(2.345);
            Console.WriteLine("my_array items are:");
            
            foreach(var item in my_aarray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            my_aarray.Remove("atul");
            Console.WriteLine("Updated array items are:");

            foreach (var item in my_aarray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
