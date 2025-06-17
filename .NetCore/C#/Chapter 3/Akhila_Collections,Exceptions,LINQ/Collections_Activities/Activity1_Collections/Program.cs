
using Activity1_Collections.Manager;

namespace Activity1_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();
            int temp = 0;
            do
            {
                Console.WriteLine("Welcome\nChoose your option:\n1.Add Employee\t2Display employees\t3.Search and Diaplay\t4.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                if(option==1)
                {
                    manager.AddEmployee();
                }
                else if(option==2)
                {
                    manager.DiplayEmployee();
                }
                else if(option==3)
                {
                    Console.WriteLine("enter the department :");
                    string dept=Console.ReadLine();
                    manager.DisplayDept(dept);

                }
                else 
                {
                    Console.WriteLine("Exit");
                    temp = 1;
                }
            
            
            } while (temp == 0);
        }
    }
}
