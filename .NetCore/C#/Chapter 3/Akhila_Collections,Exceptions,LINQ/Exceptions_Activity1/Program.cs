using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace Exceptions_Activity1
{
    
    internal class Program
    {
       
        class User
        {
            public int Id { get;set; }
            public string Name { get;set; }
            public string Email { get;set; }
            public string Phone { get; set; }
            public User() { }
            public User(int id,string name,string email,string phn)
            {
                Id= id;
                Name= name;
                Email= email;
                Phone= phn;
            }

        }
        
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int status = 1;
            int flag = 1;
            do
            {
                Console.WriteLine("Welcome to the users details:\t1.Enter details 2.Display 3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    do
                    {
                        try
                        {

                            Console.WriteLine("Enter the user details:\n ID:");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            if (Id == null)
                                throw new Exception("Id should not be a Null value.Try again!");



                            Console.WriteLine("Name:");
                            string Name = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(Name))
                                throw new Exception("Name invalid.Try again!");


                            Console.WriteLine("Email:");
                            string email = Console.ReadLine();
                            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                                throw new Exception("Email is not valid.Try again!");

                            Console.WriteLine("Phone:");
                            string phone = Console.ReadLine();
                            if (!Regex.IsMatch(phone, @"^\d{10}$")) 
                                throw new Exception("Phone number should be 10 digit.Try again!");
                            users.Add(new User(Id, Name, email, phone));
                            flag = 0;
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)

                        {
                            Console.WriteLine(ex.Message);
                        }
                    } while (flag == 1);
                }
                else if(option==2)
                {
                    Console.WriteLine("Users are:");
                    for (int i = 0; i < users.Count; i++)
                    {
                        Console.WriteLine($"Id:{users[i].Id}\nName:{users[i].Name}\nEmail:{users[i].Email}\nPhone:{users[i].Phone}");
                    }
                }
                else
                {
                    Console.WriteLine("Exit");
                    status = 0;
                }


            } while (status == 1);
        }
    }
}
