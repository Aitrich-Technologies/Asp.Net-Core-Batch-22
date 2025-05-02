namespace structMovieticket
{
    internal class Program
    {
        struct Ticket
        {
            public string MovieName;
            public string Theater;
            public int Price;
            public string SeatNumber;
        }
        static void Main(string[] args)
        {
            Ticket[] tickets = new Ticket[2];
            for (int i = 0; i < tickets.Length; i++)
            {
                Console.WriteLine($"Enter Ticket{i + 1} details:");
                Console.WriteLine("Movie Name:");
                tickets[i].MovieName = Console.ReadLine();
                Console.WriteLine("Theater: ");
                tickets[i].Theater = Console.ReadLine();
                Console.WriteLine("Price: ");
                tickets[i].Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Seat Number: ");
                tickets[i].SeatNumber = Console.ReadLine();
                Console.WriteLine("____________________");
            }
            Console.WriteLine("MovieName    Theater      Price      SeatNumber");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(tickets[i].MovieName+"    "+ tickets[i].Theater+ "     "+ tickets[i].Price+ "    "+ tickets[i].SeatNumber);
            }
            Console.WriteLine("____________________");
        }
    }
}
