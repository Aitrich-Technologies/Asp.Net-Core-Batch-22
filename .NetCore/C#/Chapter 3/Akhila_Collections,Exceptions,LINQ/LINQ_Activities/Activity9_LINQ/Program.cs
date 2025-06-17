using System.Linq;
using System.Transactions;
namespace Activity9_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var departments = new[]
            {
                new { DeptId = 1, DeptName = "HR" },
                new { DeptId = 2, DeptName = "IT" }
            };

            var employees = new[]
            {
                new { EmpId = 1, EmpName = "John", DeptId = 2 },
                new { EmpId = 2, EmpName = "Mary", DeptId = 1 }
            };
            var deptemp = from emp in employees join dept in departments on emp.DeptId equals dept.DeptId select new { emp.EmpName, dept.DeptName };

            foreach (var nwlist in deptemp)
            {
                Console.WriteLine(nwlist);
            }
        }

       
    }
}
