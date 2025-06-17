using System.Linq;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new[] { "john", "Alice", "Bob" };
            Console.WriteLine("Student's names:");
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Student's names updated:");
            var persons = from s in students select s.ToUpper(); 
            foreach (var item in persons)
            {
            
               // var st=item.ToUpper();
                Console.WriteLine(item);
            
            }
            
            
            
        }
    }
}
