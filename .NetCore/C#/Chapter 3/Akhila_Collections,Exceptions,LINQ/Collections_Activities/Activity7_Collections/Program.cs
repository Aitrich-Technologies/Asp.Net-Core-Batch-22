using System.Collections;
using Microsoft.VisualBasic;
namespace Activity7_Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable Phone_Directory= new Hashtable();
            //int flag = 0;
            Phone_Directory.Add("Atul", 12345678);
            Phone_Directory.Add("Akash", 76788989656);
            Phone_Directory.Add("Meera", 67848798);
            Phone_Directory.Add("Rohith", 5576768787);
            Phone_Directory.Add("Gauri", 567376768);
            Console.WriteLine("Saved Contacts are:");
            foreach (DictionaryEntry contact in Phone_Directory)
            {
                Console.WriteLine($"Name:{contact.Key}\t Mobile number:{contact.Value}");

            }
            Console.WriteLine("Enter contact name for search & delete");
            string name=Console.ReadLine();
            if (Phone_Directory.ContainsKey(name))
            {
                Console.WriteLine("Entered name is existing");
                Phone_Directory.Remove(name);
                Console.WriteLine($"{name} is removed from the directory.\nUpdated directory.");
                foreach (DictionaryEntry contact in Phone_Directory)
                {
                    Console.WriteLine($"Name:{contact.Key}\t Mobile number:{contact.Value}");

                }
            }
            else
            {
                Console.WriteLine("Entered name is not existing");
            }
        }
    }
}
