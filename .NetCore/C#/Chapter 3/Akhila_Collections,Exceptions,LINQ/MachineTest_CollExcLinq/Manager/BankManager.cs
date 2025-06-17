using MachineTest_CollExcLinq.Exceptions;
using MachineTest_CollExcLinq.Interfaces;
using MachineTest_CollExcLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_CollExcLinq.Manager
{
    public class BankManager: IBankAccount
    {
        List<BankAcount> bankAccounts=new List<BankAcount>();
        int number = 1;


       public void Login(string user,string passwrd)
        {
           
            Console.WriteLine("Enter userid:");
            string usid = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd = Console.ReadLine();
            //bool validUser = customers.Any(c => c.userid == usid && c.passsword == pwd && c.user_type == "customer");
            if(usid==user&&pwd==passwrd)
            {
                MainMenu();
                return;
            }
           
            else
            {
                Console.WriteLine("Invalid User");
                return;
            }

        
        }
        public void MainMenu()
        {
            int flag = 0;
            do
            {
                Console.WriteLine("Select your Option\n1.Add a new Account\n2.Remove an Account\n3.Display All Account\n4.Exit");
                string option=Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddAccount();
                        break;
                    case "2":
                        RemoveAccount();
                        break;
                    case "3":
                        DisplayAllAccounts();
                        break;
                    case "4":
                        Console.WriteLine("Exit");
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid option.Try Again!");
                        break;
                }
            } while (flag == 0);
        }


        public void AddAccount()
        {
            Console.WriteLine("Enter your details:\nAccount Holder Name:");
            string nam=Console.ReadLine();
            Console.WriteLine("First Deposited Amount:");
            int bal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Savings/Current Account:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Phone number:");
            string ph = Console.ReadLine();
            BankAcount account = new BankAcount(number,nam,bal,type,ph);
            number++;
            bankAccounts.Add(account);

        }

        public  void RemoveAccount()
        {
            try
            {
                Console.WriteLine("For deleting your account:\nEnter your AccountHolder Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your Account Number:");
                int numb = Convert.ToInt32(Console.ReadLine());
                var bankaccount = bankAccounts.FirstOrDefault(a => a.AccountNumber == numb);
                if (bankaccount != null)
                {
                    Console.WriteLine($"Account Holder:{name}and Account number:{numb} is going to delete. ");
                    bankAccounts.Remove(bankaccount);
                }
                else
                {
                    throw new DoesNotExistsException("Invalid Account number");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Not existing");
            }
        }

        public void DisplayAllAccounts()
        {
            Console.WriteLine("Account holders details are:\nAccount No.\tHolderNmae\tBalance\tAccountType\tPhoneNo");
            foreach(BankAcount bankAcount in bankAccounts)
            {
                Console.WriteLine($"{bankAcount.AccountNumber}\t{bankAcount.AccountHoldername}\t{bankAcount.AccountBalance}\t{bankAcount.AccountType}\t{bankAcount.PhoneNo}");
            }
        }
    }
}
