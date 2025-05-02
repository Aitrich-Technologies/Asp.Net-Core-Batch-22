namespace structEmployee
{
    internal class Program
    {
        struct Employee
        {
            public int id;
            public string name;
            public string dept;
            public int salary;
        };
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[5];
            //Read details of employees
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter details for Employee {i+1}:");
                Console.WriteLine("Id: ");
                employee[i].id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name: ");
                employee[i].name=Console.ReadLine();
                Console.WriteLine("Department:");
                employee[i].dept = Console.ReadLine();
                Console.WriteLine("Salry: ");
                employee[i].salary=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Employee names from HR Department:");
            for (int i=0;i<5;i++)
            {
               
                if (employee[i].dept == "HR")
                {
                    Console.Write(employee[i].name, "     ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("High Salary");
            int min = 0;
            int max = 250000;
            int temp = 0;
            for(int i=0; i<5;i++)
            {
                if (employee[i].salary > max)
                {
                    max = employee[i].salary;
                    temp = i;
                }
                else if(employee[i].salary < min)
                {
                    min = employee[i].salary;
                }
            }
            Console.WriteLine("High Salary of Employee is {0}", employee[temp + 1].name);
        }
    }
}
