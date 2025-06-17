using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Activity2_Collections.Models;

namespace Activity2_Collections.Manager
{
    public class ProductManager
    {
        Product product = new Product();
        Dictionary<int, string> dict_products = new Dictionary<int, string>();


        public void AddtoCart()
        {
            Console.WriteLine("Enter Product Details:\nProduct ID:");
            product.ProductID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product Name:");
            product.ProductName = Console.ReadLine();
            dict_products.Add(product.ProductID, product.ProductName);

        }


        public void Display()
        {
            Console.WriteLine("Products in Cart");
            foreach (var item in dict_products.Values)
            {
                Console.WriteLine(item);
            }
        }


        public void DeleteProduct()
        {
            Console.WriteLine("Enter Product id:");
            int pid = Convert.ToInt32(Console.ReadLine());
            foreach (var item in dict_products.Keys)
            {
                if (dict_products.ContainsKey(pid))
                {
                    Console.WriteLine("There exists");
                    dict_products.Remove(pid);
                    Console.WriteLine($"{pid} removed");
                    return;
                }
                else
                {
                    Console.WriteLine("No product with this id.sorry,try later.");
                    return;
                }
            }
        }


        public void SearchProduct()
        {
            Console.WriteLine("Enter Product id:");
            int pid = Convert.ToInt32(Console.ReadLine());
            foreach (var item in dict_products.Keys)
            {
                if (dict_products.ContainsKey(pid))
                {
                    Console.WriteLine("There exists");
                    return;
                }
                else
                {
                    Console.WriteLine("No product with this id.sorry,try later.");
                    return;
                }
            }
        }
    }
}
