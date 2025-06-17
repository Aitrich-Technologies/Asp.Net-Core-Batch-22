using System.Linq;
namespace Activity6_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new[]
            {
                new { Title = "C# Basics", Category = "Programming" },
                new { Title = "Python", Category = "Programming" },
                new { Title = "Cooking 101", Category = "Cooking" }
            };
            var booklist=books.OrderBy(book=>book.Category).ThenBy(book=>book.Title);

            foreach(var book in booklist)
            {
                Console.WriteLine(book);
            }
        }
    }
}
