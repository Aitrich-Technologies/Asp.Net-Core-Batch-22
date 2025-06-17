using System.Collections;
namespace Activity9_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("File1");
            stack.Push("File2");
            stack.Push("File3");
            stack.Push("File4");
            Console.WriteLine("Saved Files:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Doing Undo");
            stack.Pop();
            Console.WriteLine(stack.Peek());
            stack.Pop();
            
            Console.WriteLine("Hello, World!");
        }
    }
}
