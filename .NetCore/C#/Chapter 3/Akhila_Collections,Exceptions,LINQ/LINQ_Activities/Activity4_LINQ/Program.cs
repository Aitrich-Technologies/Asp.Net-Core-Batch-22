using System.Linq;
namespace Activity4_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new[]
            {
                new { Name = "Alice", Salary = 3000 },
                new { Name = "Bob", Salary = 2000 },
                new { Name = "Charlie", Salary = 4000 }
            };

            var emplist =from emp in employees orderby emp.Salary select emp ;
            foreach (var item in emplist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
