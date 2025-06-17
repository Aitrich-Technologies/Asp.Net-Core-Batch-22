using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop4_CollExcpLinq.Interfaces;
using Workshop4_CollExcpLinq.Repository;
using Workshop4_CollExcpLinq.Models;
using System.Text.RegularExpressions;
using Workshop4_CollExcpLinq.Exceptions;
using Workshop4_CollExcpLinq.Enums;

namespace Workshop4_CollExcpLinq.Manager
{
    public class PublicManager:IMenu
    {
        UserRepository userRepository = new UserRepository();
        public User Loggeduser = new User();
        bool _isLogged = false;
        IMenu menu;

        public void DisplayMenu()
        {
            showUserMenu();

        }
        private void showUserMenu()
        {
            bool exitProgram=false;

            while(!exitProgram)
            {
                Console.WriteLine("choose an option: \n1.Register\n2.Login\n3.Exit");

                string option1= Console.ReadLine();
                switch (option1)
                {
                    case "1":
                        RegisterJobSeeker();
                        break;
                    case "2":
                        LoginJobSeeker();
                        if (_isLogged)
                            menu.DisplayMenu();
                        break;
                    case "3":
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }


        private string GetEmail()
        {
            try
            {
                Console.WriteLine("Please enter the email address:");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatExceptions("Email is not in correct foramat");
                return email;
            }
            catch(InvalidFormatExceptions ex)
            {
                Console.WriteLine(ex.Message + "\n"+"Try Again");
                return GetEmail();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
        }

        private string GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your Phone Number:");
                string phn = Console.ReadLine();
                Regex regex = new Regex(@"^\d{10}$");
                if (!regex.IsMatch(phn))
                    throw new InvalidFormatExceptions("Phone number is invalid");

                return phn;
            }
            catch(InvalidFormatExceptions ex)
            {
                Console.WriteLine(ex.Message + "\n" + "Try Again");
                return GetPhoneNumber();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Enter valid Phone number");
                    return GetPhoneNumber();
            }
        }
        void RegisterJobSeeker()
        {
            try
            {
                User newJobseeker = new User();
                Console.WriteLine("Please enter yoour First name:");
                newJobseeker.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter your Last name:");
                newJobseeker.LastName = Console.ReadLine();
                newJobseeker.Email = GetEmail();
                newJobseeker.Phone = GetPhoneNumber();
                Console.WriteLine("Please enter a Password:");
                newJobseeker.Password = Console.ReadLine();
                userRepository.register(newJobseeker);

                Console.WriteLine("Registration Successfull");

            }
            catch (UserAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }


        void LoginJobSeeker()
        {
            try
            {
                string email = GetEmail();
                Console.WriteLine("Please enter your Password");
                string password = Console.ReadLine();
                Loggeduser = userRepository.login(email, password);
                if (Loggeduser != null)
                {
                    Console.WriteLine("Login successful!");
                    _isLogged = true;
                    Console.WriteLine("Welcome " + Loggeduser.FirstName);
                    if (Loggeduser.Role == Roles.JobSeeker)
                    {
                        menu = new UserManager(Loggeduser);


                    }
                }
                else
                {
                    Console.WriteLine("Login failed.Try again!");

                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
