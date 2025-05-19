namespace ProductObjarrayOOPs
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public int ProductPrice;

        public Product(int pId,string Pname,int Pprice)

        {
            ProductId = pId;
            ProductName = Pname;
            ProductPrice = Pprice;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = { new Product(1, "Soap", 25), new Product(2, "Shampoo", 55), new Product(3, "Cream", 90), new Product(4, "Choclate", 50), new Product(5, "Book", 50) };
            //products[0] = new Product(1, "Soap", 25);
            //products[1] = new Product(2, "Shampoo", 55);
            //products[2] = new Product(3, "Cream", 90);
            //products[3] = new Product(4, "Choclate", 50);
            //products[4] = new Product(5, "Book", 50);
            Console.WriteLine("Product Details:");
            foreach (Product p in products)
            {
                Console.WriteLine("ProductID: {0}\t ProductName: {1}\t Price: {2}",p.ProductId,p.ProductName,p.ProductPrice);
            }
        }
    }
}