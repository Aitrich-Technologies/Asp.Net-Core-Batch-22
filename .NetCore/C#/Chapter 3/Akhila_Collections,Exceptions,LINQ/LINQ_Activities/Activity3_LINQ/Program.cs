using System.Linq;
namespace Activity3_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new[]
            {
                new { Id = 1, Name = "Pen", Price = 10 },
                new { Id = 2, Name = "Notebook", Price = 25 }
            };
            var list=from product in products select new { product.Name , price=product.Price + 5 };
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
