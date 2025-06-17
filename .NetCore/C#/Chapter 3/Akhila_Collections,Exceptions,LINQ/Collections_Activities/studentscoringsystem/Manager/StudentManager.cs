using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentscoringsystem.Models;

namespace studentscoringsystem.Manager
{
    
    public class StudentManager
    {
        List<student> student_list = new List<student>();
        int no = 0;
        public void AddStudent()
        {
            Console.WriteLine("Enter the name of the student: ");
            string nam=Console.ReadLine();
            Console.WriteLine("Enter the age of the student:");
            int ag=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the score:");
            int scr=Convert.ToInt32(Console.ReadLine());
            student_list.Add(new student(no++,nam,ag,scr));
        }
        public void Display()
        {
            foreach (student student in student_list)
            {
                Console.WriteLine($"{student.ID}\t{student.Name}\t{student.Age}\t{student.Score}");
            }
        }
        public void CalculateAvg()
        {
            int min = 20;
            int max = 90;
            foreach(student student in student_list)
            {
                if(student.Score<min)
                {  min = student.Score; }
                if (student.Score > max)
                { max = student.Score; }
            }
        }
    }
}
