using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
namespace Activity8_LINQ
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
            /* method1
              var result = customers.GroupJoin(orders,
                                            customer => customer.Id,         // outer key
                                            order => order.CustomerId,       // inner key
                                            (customerId, customerOrders) => new
                                            {
                                                CustomerName = customerId.Name,
                                                OrderIds = customerOrders.Select(o => o.OrderId).ToList()
                                            }
                                          );*/

            //another method2
            /*from cust in customers
            join ord in orders
            on cust.Id equals ord.CustomerId
            into customerOrders
            select new
            {
                CustomerName = cust.Name,
                OrderIds = customerOrders.Select(o => o.OrderId).ToList()
            };*/

            var custorder =from customer in customers join order in orders on customer.Id equals order.CustomerId into customerOrder select new { Name=customer.Name ,orderID=customerOrder.Select(o => o.OrderId).ToList() };

            //var groups = from custord in custorder group custord by custord.OrderId;
            //// var grpcustorder = from newlist in custorder group newlist by newlist.OrderId;
            foreach (var cust in custorder )
            {
                
                Console.WriteLine(cust.Name);
                foreach(var ord in cust.orderID)
                {
                    Console.WriteLine(ord);
                }
            }
        }
    }
}
