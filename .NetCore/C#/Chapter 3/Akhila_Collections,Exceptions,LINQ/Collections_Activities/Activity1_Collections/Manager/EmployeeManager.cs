using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity1_Collections.Models;
using System.Collections.Generic;

namespace Activity1_Collections.Manager
{
    public class EmployeeManager
    {
        //Employee[] employees = new Employee[5];
        Employee employee=new Employee();
        List<Employee> employees=new List<Employee>(5);
        public int count = 0;
        public int id = 1;
        public void AddEmployee()
        {
            if (employees?.Count < 5)
            {
                Console.WriteLine("Enter the details of Employee:");
                employee.ID = id;
                id++;
                Console.WriteLine("Name:");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Department:");
                employee.Department = Console.ReadLine();
                Console.WriteLine("Salary:");
                employee.Salary = Convert.ToInt32(Console.ReadLine());
                //employee = new Employee(employee.ID, employee.Name, employee.Department, employee.Salary);
                employees.Add(new Employee(employee.ID, employee.Name, employee.Department, employee.Salary));
                return;
            }
            else 
            {
                Console.WriteLine("Maximum limit reached.Try Later");
            }
            return;
        }
        

        public void DiplayEmployee()
        {
            Console.WriteLine("Details of Employees:\nID\tName\tDepartment\tSalary");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.ID}\t{employee.Name}\t{employee.Department}\t\t{employee.Salary}");
            }
            return;

        }


        public void DisplayDept(string dept)
        {
            Console.WriteLine($"Employees in {dept} department\n");
            foreach (Employee employee in employees)
            {
                
                if (dept == employee.Department)
                {
                    Console.WriteLine($"{employee.ID}\t{employee.Name}\t{employee.Department}\t{employee.Salary}");
                }
            }
            return;
            
        }
    }
}
