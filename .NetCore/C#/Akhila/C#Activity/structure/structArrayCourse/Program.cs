using System.Xml.Linq;

namespace structArrayCourse
{
    internal class Program
    {
        struct Course
        {
            public string CourseID;
            public string CourseName;
            public string Credits;

            public Course(string id, string name, string score)
            {
                CourseID = id;
                CourseName = name;
                Credits = score;
            }

            // Display student details
            public void DisplayCourse()
            {
                Console.WriteLine("Courses:");
                Console.WriteLine("\tCourseId    : " + CourseID);
                Console.WriteLine("\tCourseName   : " + CourseName);
                Console.WriteLine("\tCredit   : " + Credits);
                Console.WriteLine("\n");
            }
        }
        static void Main(string[] args)
        {
            //creating array of structures
            Course[] courses = [new Course("a123", ".net", "A"), new Course("a3", "vb.net", "A*"), new Course("b3", "asp.net", "A") ];
                     


            courses[0].DisplayCourse();
            courses[1].DisplayCourse();
            courses[2].DisplayCourse();
            
        }
    }
}
