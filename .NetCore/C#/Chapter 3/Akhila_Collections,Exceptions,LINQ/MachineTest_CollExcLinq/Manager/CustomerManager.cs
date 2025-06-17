using MachineTest_CollExcLinq.Interfaces;
using MachineTest_CollExcLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_CollExcLinq.Manager
{
    public class CustomerManager:ICustomer
    {
        List<BankAcount> account = new List<BankAcount>();
        List<Customer> customers = new List<Customer>();
        BankAcount LoggedCust=new BankAcount();
        public void cust_menu()
        {
            int flg = 0;
            do
            {
                Console.WriteLine("1.Register\n2.Login\n3.Exit");
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        RegisterCust();
                        break;
                    case "2":
                        bool verify=LoginCust();
                        if (verify == true) CustomerMenu();
                        else cust_menu();
                        break;
                    case "3":
                        flg = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (flg == 0);
        }
        public void RegisterCust()
        {
            Console.WriteLine("Enter name:");
            string nam = Console.ReadLine();
            Console.WriteLine("Enter your userid:");
            string userid = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();
            string user = "customer";
            Console.WriteLine("Enter Phone:");
            string phn = Console.ReadLine();
            Customer newcust=new Customer(nam,userid, pass,user,phn);
            customers.Add(newcust);
        }
        public bool LoginCust()
        {
            Console.WriteLine("Enter userid:");
            string usid = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pwd = Console.ReadLine();
            Console.WriteLine("Enter Phone:");
            string phn=Console.ReadLine();
            bool validUser=customers.Any(c=>c.userid == usid && c.passsword==pwd && c.user_type=="customer");
            foreach (BankAcount acount in account)
            {
                if (acount.PhoneNo == phn)
                {
                    LoggedCust = acount;
                }
            }
          
            if(validUser)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid User");
                return false;
            }

        }


        public void CustomerMenu()
        {
            int status = 0;
            do
            {
                Console.WriteLine("Select your action:\n1.Deposit Money\n2.Withdraw Money\n 3.Check Balance\n4.Exit");
                string op = Console.ReadLine();
                switch(op)
                {
                    case "1":
                        DepositMoney(LoggedCust);
                        break;
                    case "2":
                        WithdrawMoney(LoggedCust);
                        break;
                    case "3":
                        CheckBalance(LoggedCust);
                        break;
                    case "4":
                        status = 1;
                        break;
                    default:
                        Console.WriteLine("Wrong option.Try again!");
                        break;
                }
            }while(status==0);
        }

        public void DepositMoney(BankAcount logged)
        {
            Console.WriteLine("Enter the amount to deposit:");
            int amnt=Convert.ToInt32(Console.ReadLine());
            if (amnt < 0)
            {
                Console.WriteLine("Invalid amount");
                return;
            }
            else
            {
                logged.AccountBalance += amnt;
            }

        }
        public void WithdrawMoney(BankAcount logged)
        {
            Console.WriteLine("Enter the amount to withdraw:");
            int amnt = Convert.ToInt32(Console.ReadLine());
            if (LoggedCust.AccountBalance < 0)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            else
            {
                logged.AccountBalance -= amnt;
            }
        }
        public void CheckBalance(BankAcount logged)
        {
            Console.WriteLine($"Balance amount of {logged.AccountHoldername} is:{logged.AccountBalance}");
        }
    }
}
