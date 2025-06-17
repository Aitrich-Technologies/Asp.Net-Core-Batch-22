using System.Linq;
namespace Activity5_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new[]
            {
                new { Name = "John", Grade = 80 },
                new { Name = "Alice", Grade = 90 },
                new { Name = "Mark", Grade = 70 }
            };
            var studentlist=from student in students orderby student.Grade descending  select student;
            foreach (var student in studentlist)
            {
                Console.WriteLine(student);
            }
        }
    }
}
