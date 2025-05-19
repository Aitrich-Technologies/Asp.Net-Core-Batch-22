namespace OverrdSchlMgt
{
    class Person
    {
        public virtual void GetRole()
        {
            Console.WriteLine("Person");
        }
    }
    class Student : Person 
    {
        public override void GetRole()
        {
            Console.WriteLine("Student");
        }
    }
    class Teacher:Person
    {
        public override void GetRole()
        {
            Console.WriteLine("Teacher");  
        } 
    }
    class Admin:Person
    {
        public override void GetRole()
        {
            Console.WriteLine("Admin");
        }
    }

    internal class Program
    {
        static void DisplayRole(Person p)
        {

            p.GetRole();
        }
        static void Main(string[] args)
        {
            DisplayRole(new Person()); //base class
           DisplayRole(new Student()); //derived class
            DisplayRole(new Teacher()); //derived class
            DisplayRole(new Admin());  //derived class
        }
    }
}
