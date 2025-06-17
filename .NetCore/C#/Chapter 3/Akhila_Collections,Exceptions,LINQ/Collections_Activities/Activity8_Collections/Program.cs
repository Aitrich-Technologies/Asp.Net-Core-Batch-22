using System.Collections;
namespace Activity8_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue ticketBooking = new Queue();
            //Console.WriteLine("Enter the name of the person:");
            //string name=
            ticketBooking.Enqueue("Ram");
            ticketBooking.Enqueue("Syam");
            ticketBooking.Enqueue("Rohith");
            ticketBooking.Enqueue("Gauri");
            Console.WriteLine("Display the customers:");
            foreach(var item in ticketBooking)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"First served to {ticketBooking.Dequeue()}");
            Console.WriteLine("Updated queue:");
            foreach (var item in ticketBooking)
            {
                Console.WriteLine(item);
            }
        }
    }
}
