namespace Activity7_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new[]
            {
             new { Id = 1, Name = "Alice" },
             new { Id = 2, Name = "Bob" }
            };

            var orders = new[]
            {
                new { OrderId = 101, CustomerId = 1 },
                new { OrderId = 102, CustomerId = 1 },
                new { OrderId = 103, CustomerId = 2 }
            };
            var custorder = from customer in customers join order in orders on customer.Id equals order.CustomerId select new { customer.Name, order.OrderId };
            foreach (var customer in custorder)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
