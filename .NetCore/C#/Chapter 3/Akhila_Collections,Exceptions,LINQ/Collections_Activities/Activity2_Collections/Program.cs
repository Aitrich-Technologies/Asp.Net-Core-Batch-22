using Activity2_Collections.Manager;

namespace Activity2_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();
            int temp = 0;
            do
            { 
                Console.WriteLine("Welcome,Enter your choice:\n1.Add item\t2.Display items\t3.Delete item with product id\t4.Search an item with product id\t5.Exit");
                string option=Console.ReadLine();
                if(option=="1")
                {
                    manager.AddtoCart();
                }
                else if(option=="2")
                {
                    manager.Display();
                }
                else if (option == "3")
                {
                    manager.DeleteProduct();
                }
                else if (option == "4")
                {
                    manager.SearchProduct();
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
