using System.Security.Cryptography.X509Certificates;

namespace PersonInhrtOOPs
{
    class Person
    {
        protected string name;
    }
    class Employee : Person
    {
        int employeeId;
        public void savedetails()
        {
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            employeeId=Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name :{0}", name);
            Console.WriteLine("Employee ID:{0}", employeeId);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            employee.savedetails();
            employee.display();
        }
    }
}
