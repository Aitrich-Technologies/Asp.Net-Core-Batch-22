namespace encapsStudEnrollOOPs
{
    abstract class User
    {
        public abstract void Login();
    }
    class Student:User
    {
        string UserName;
        string Password;
        public string uname
        {
            get { return UserName; }
            set { UserName = value; }
        }

        public string pwd
        {
            get { return Password; }
            set { Password = value; }   
        }
        public override void Login()
        {
            Console.WriteLine("Student with username:{0} and password:{1} logined",uname,pwd);
        }
        public void EnRoll()
        {
            Console.WriteLine("{0} is Enrolled", uname);
        }
    }
    class Instructor : User
    {
        string InsName;
        string InsPassword;
        public string InstructorName
        {
            get { return InsName; }
            set {  InsName = value; }
        }
        public string InstructorPassword
        {
            get { return InsPassword; }
            set{ InsPassword = value; }
        }
        public override void Login()
        {
            Console.WriteLine("Instructor with username:{0} and password:{1} logged in", InstructorName, InstructorPassword);
        }
        public void CreateCourse()
        {
            Console.WriteLine("Course added by {0}",InsName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student();
            student.uname = "Rohith";
            student.pwd = "123";
            student.Login();
            student.EnRoll();


            Instructor instructor=new Instructor();
            instructor.InstructorName = "Sir.Manoj";
            instructor.InstructorPassword = "121";
            instructor.Login();
            instructor.CreateCourse();
        }
    }
}
