namespace EncapStudentOOps
{
    class Student
    {
        string studentName;
        int studentAge;
        string studentGrade;
        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int Age
        {
            get { return studentAge; }
            set {
                if (value > 0)
                {
                    studentAge = value;
                }
                else
                {
                    Console.WriteLine("Enter the proper age");
                }
                    
                }
        }
        public string Grade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Rohith";
            student.Age = 9;
            student.Grade = "A";
            Console.WriteLine("Student Name:{0}\nStudent Age:{1}\nStudent Grade:{2}\n",student.Name,student.Age,student.Grade);
            
        }
    }
}
