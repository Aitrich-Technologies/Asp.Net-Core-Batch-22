namespace ticketprice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 20;
            int ticket=100;
            if(age<5 || age>60)
            {
                ticket = 0;
                Console.WriteLine("Free Ticket");
            }
            else if(age>=5 && age<=13)
            {
                ticket =ticket/ 2;
                Console.WriteLine("Half Ticket=50");
            }
            else 
            {
                Console.WriteLine("Full Ticket=100");
            }
                          //Console.WriteLine("Hello, World!");
        }
    }
}
