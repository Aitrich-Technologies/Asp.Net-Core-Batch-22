using System.Linq;
namespace Activity10_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var authors = new[]
            {
                new { Id = 1, Name = "Author A" },
                new { Id = 2, Name = "Author B" }
            };

            var books = new[]
            {
                new { Title = "Book 1", AuthorId = 1 },
                new { Title = "Book 2", AuthorId = 2 },
                new { Title = "Book 3", AuthorId = 1 }
            };
            var bookauthor = from author in authors join book in books on author.Id equals book.AuthorId select new { Title = book.Title, Author = author.Name };
            foreach (var auth in bookauthor)
            {
                Console.WriteLine(auth);
            }
        }
    }
}
