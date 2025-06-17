
using System.Collections.Generic;
namespace Activity5_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> students = new SortedList<int, string>();
            int temp = 0;
            do
            {
                Console.WriteLine("Hello,student Details:\n1.Add Students\t2.Sort&View\t3.Update by rollnumber\t4.Exit");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Roll No:");
                    int rollno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();
                    students.Add(rollno, name);
                }
                else if (option == "2")
                {
                    foreach(var item in students)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if(option=="3")
                {
                    Console.WriteLine("Enter the roll number whose name want to update:");
                    int numb=Convert.ToInt32(Console.ReadLine());
                    int indx=students.IndexOfKey(numb);
                    int status = 0;
                    foreach (var item in students) 
                    {
                        if (numb == item.Key)
                        {

                            Console.WriteLine($"Change the name {item.Value}.Enter new name:");
                            string newname = Console.ReadLine();
                            students[numb] = newname;
                            //students.Add(numb, newname);
                            Console.WriteLine("Updated");
                            status = 1;
                            break;
                  
                        }

                       
                    }

                    if(status==0)
                        Console.WriteLine("Entered Roll number is wrong.Try later.");

                    
                    
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
