using System.Linq;
namespace Activity2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new[] { "Michael", "Sarah", "Tom" };
            var list = from t in names select t[0];



            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
