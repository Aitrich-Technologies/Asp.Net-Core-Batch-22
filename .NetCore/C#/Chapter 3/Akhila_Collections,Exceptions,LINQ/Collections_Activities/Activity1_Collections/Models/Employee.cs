using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_Collections.Models
{
    public class Employee
    {
        public int ID;
        public string Name;
        public string Department;
        public int Salary;
        public Employee() { }
        public Employee(int id, string name, string department, int salary)
        {
            ID = id;
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}
