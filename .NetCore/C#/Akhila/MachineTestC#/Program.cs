using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace machineTest
{

    
    internal class Program
    {
        
        struct Patient
        {
            public int ID=0;
            public string Name;
            public int Age;

            public Patient(int c,string n, int a)
            {
                ID = c;
                Name = n;
                Age = a;

            }
            

        }
        
        static void Main(string[] args)
        {
            Patient[] patients = new Patient[5];
            Console.Write("Welcome to Hospital Management");
            int temp = 0;
            int count = 0;
            do
            {
                Console.WriteLine("Enter the action:");
                Console.WriteLine("1.Enter details of Patients");
                Console.WriteLine("2.Display details of Patients");
                Console.WriteLine("3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
               

                switch(choice)
                {
                    case 1:
                        
                        if(count<=5)
                        {
                            Console.WriteLine("Enter the name of the Patient:");
                            string nam = Console.ReadLine();
                            Console.WriteLine("Enter the Age of the Patient:");
                            int ag = Convert.ToInt32(Console.ReadLine());

                            patients[count]=new Patient(count,nam, ag);
                            count++;
                            Console.WriteLine("Count is:{0}", count);
                        }
                        else
                        {
                            Console.WriteLine("Less Storage");
                        }
                            break;
                    case 2:
                        
                        Console.WriteLine("Details of Patients:");
                        
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Patient's ID:{0}", patients[i].ID);
                            Console.WriteLine("Patient's Name:{0}", patients[i].Name);
                            Console.WriteLine("Patient's Age:{0}", patients[i].Age);
                            Console.WriteLine("_____________________________________");
                        
                      
                        }
                        break;
                    case 3:
               
                        Console.WriteLine("Exit done");
                        temp = 1;
                        break;

                    
                }
            
            } while (temp == 0);
        }
    }
}
