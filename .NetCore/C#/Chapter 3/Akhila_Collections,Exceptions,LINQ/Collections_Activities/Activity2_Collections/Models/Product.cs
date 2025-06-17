using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2_Collections.Models
{
    public class Product
    {
        public int ProductID;
        public string ProductName;
        public Product() { }
        public Product(int productID, string productName)
        {
            ProductID = productID;
            ProductName = productName;
        }
    }
}
