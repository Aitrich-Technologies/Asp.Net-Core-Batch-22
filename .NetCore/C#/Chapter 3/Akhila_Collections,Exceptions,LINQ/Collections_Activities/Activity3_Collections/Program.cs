
using System.Collections.Generic;

namespace Activity3_Collections
{
  public class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            int temp = 0;
            do
            {
                Console.WriteLine("Hello,Welcome!Enter option:\n1.Enqueue\t2.Display\t3.Who got served\t4.Dequeue all\t5.Exit\n");
                string option = Console.ReadLine();
                if(option=="1")
                {
                    Console.WriteLine("Enter the name of the customer:");
                    string name=Console.ReadLine();
                    customers.Enqueue(name);
                    Console.WriteLine($"{name} added.");
                }
                else if(option=="2")
                {
                    Console.WriteLine("Customers are:");
                    foreach (var item in customers)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if(option=="3")
                {
                    string service = customers.Dequeue();
                    Console.WriteLine($"{service} being served");
                }
                else if(option=="4")
                {
                    Console.WriteLine("All are getting served.");

                    for (int i = 0; i <= customers.Count; i++)
                    {
                        if (customers.Count > 0)
                        {
                            Console.WriteLine($"{customers.Dequeue()} got served");

                        }
                        else if(customers.Count == 0)
                        {
                            Console.WriteLine("Queue is empty");
                        }
                    
                    }
                    
                }
                else 
                {
                    Console.WriteLine("Exit");
                    temp = 1;
                }


             }while (temp == 0);
        }
    }
}
