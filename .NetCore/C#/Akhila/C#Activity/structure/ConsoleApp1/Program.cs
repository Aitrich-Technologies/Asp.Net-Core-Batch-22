namespace ConsoleApp1
{
    internal class Program
    {
        struct Laptop
        {
            public string Brand;
            public int RAM;
            public int Storage;
            public int Price;

            public Laptop(string b, int r, int s,int p)
            {
              Brand = b;
              RAM = r;
            Storage = s;
                Price = p;
            }
        }
        static void Main(string[] args)
        {
            Laptop laptops1 = new Laptop("Dell", 8, 512, 250000);
            Console.WriteLine($"Laptop 1: ({laptops1.Brand}, {laptops1.RAM}, {laptops1.Storage}, {laptops1.Price})");
            Console.WriteLine("-------------");
            Laptop laptops2= new Laptop("Lenovo",16,1024,1000000);
            Console.WriteLine($"Laptop 2: ({laptops2.Brand},{laptops2.RAM}, {laptops2.Storage}, {laptops2.Price})");
            Console.WriteLine("-------------");
        }
    }
}
