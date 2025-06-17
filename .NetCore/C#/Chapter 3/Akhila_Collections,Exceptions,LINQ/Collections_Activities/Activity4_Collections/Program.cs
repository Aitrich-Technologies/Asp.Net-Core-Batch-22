using System.Collections.Generic;
namespace Activity4_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            Stack<string> page_names= new Stack<string>();
            do
            {
                Console.WriteLine("Hello, See the Page names here!Choose your option:\n1.Push\t2.Pop\t3.current and Previous\t4.Display\t5.Exit\n");
                string option=Console.ReadLine();
                if(option=="1")
                {
                    Console.WriteLine("Enter the name of the page you visited:");
                    string page=Console.ReadLine();
                    page_names.Push(page);
                    Console.WriteLine($"{page} visited");
                }
                else if(option=="2")
                {
                    string page = page_names.Pop();
                    Console.WriteLine($"Popping the last page:{page}");
                    string redpage = page_names.Peek();
                    Console.WriteLine($"redirected into {redpage}");
                }
                else if(option=="3")
                {
                    string redpage = page_names.Peek();
                    Console.WriteLine($"Previous page:{redpage}");
                    page_names.Pop();
                    string page = page_names.Peek();
                    Console.WriteLine($"Current page:{page}");
                }
                else if(option=="4")
                {
                    foreach(var name in page_names)
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    Console.WriteLine("Exit");
                    temp = 1;
                }


            } while (temp == 0);
            
        }
    }
}
