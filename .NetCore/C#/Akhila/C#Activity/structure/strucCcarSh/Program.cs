namespace ConsoleApp3
{
    struct Car
    {
        public string Model;
        public string Brand;
        public int Price;
        public int Year;
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Car {i + 1} details:");
                Console.WriteLine("Model: ");
                cars[i].Model = Console.ReadLine();
                Console.WriteLine("Brand: ");
                cars[i].Brand = Console.ReadLine();
                Console.WriteLine("Price: ");
                cars[i].Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Year of Manufacturing: ");
                cars[i].Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("     ________________________              ");
            }
            Console.WriteLine("     ________________________              ");
            Console.WriteLine("Cars Manufactured 2020 and above are:");
            for (int i = 0; i < 3; i++)
            {
                if (cars[i].Year >= 2020)
                {
                    Console.WriteLine(cars[i].Model+ "   "+ cars[i].Brand+ "    "+cars[i].Price+ "    "+ cars[i].Year);
                }
                Console.WriteLine("     ________________________              ");
            }
        }
            
    }
}
