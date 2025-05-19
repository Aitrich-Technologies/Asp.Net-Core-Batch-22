namespace encapsPayroll
{
    class Employee
    {
        string Name;
        int baseSalary;
        public string EmpName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int BSal
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        public void CalculateSalary()
        {
            Console.WriteLine("Base salary is {0}", baseSalary);
        }
    }

    class Manager : Employee
    {
        int Bonus;
        //int total;
        public int bon
        {
            get { return Bonus; }
            set { Bonus = value; }
        }
        //public int tot
        //{
        //    get { return total; }
        //    set{ total = BSal; }
        //}
        public void CalculateSalary()
        {
            BSal = BSal + Bonus;
            Console.WriteLine("Total Salary with bonus is {0}",BSal);
        }
    }

    class Developer:Employee
    {
        int overtimePay;
        public int ovetp
        {
            get { return overtimePay; }
            set { overtimePay = value; }
        }
        public void CalculateSalary()
        {
            BSal = BSal+overtimePay;
            Console.WriteLine("Total Salary with bonus is {0}", BSal);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee();
            employee.BSal = 1000;
            employee.CalculateSalary();

            Manager manager=new Manager();
            manager.BSal = 1000;
            manager.bon = 100;
            manager.CalculateSalary() ;

            Developer developer=new Developer();
            developer.BSal = manager.BSal;
           
            developer.ovetp = 100;
            developer.CalculateSalary();
        }
    }
}
