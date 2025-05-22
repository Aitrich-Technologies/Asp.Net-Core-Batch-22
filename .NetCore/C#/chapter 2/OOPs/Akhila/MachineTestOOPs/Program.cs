using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using MachineTestOOPs.Manager;
using MachineTestOOPs.Models;

namespace MachineTestOOPs
{
   
    public class Program
    {
        SavingsAccount savingsAccount;
        CurrentAccount currentAccount;
        //AccountManager accountManager=new AccountManager();
        static void Main(string[] args)
        {
           
            
            int temp = 0;
            do
            {

                Console.WriteLine("Welcome to the Bank System: \n1.Savings Account\t2.Current Account\t3.Exit");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Console.WriteLine("Enter your Name:");
                        string suser = Console.ReadLine();
                        Console.WriteLine("Enter your Deposit:");
                        double sbal = Convert.ToDouble(Console.ReadLine());
                        SavingsAccount savingsAccount = new SavingsAccount(suser, sbal,0);
                        savingsAccount.CalculateInterest();
                        Console.WriteLine("Balance of Savings Account (with interest 5% ):{0}", savingsAccount.Balance);
                        Console.WriteLine("Maintenance fee(100/-) will be deducted from your balance.");
                        AccountManager accountManager = new AccountManager();
                        accountManager.ApplyMaintenanceFee(100,savingsAccount.Balance);
                        break;
                    case "2":
                        Console.WriteLine("Enter your Name:");
                        string cuser = Console.ReadLine();
                        Console.WriteLine("Enter your balance:");
                        double cbal=Convert.ToDouble(Console.ReadLine());
                        CurrentAccount currentAccount = new CurrentAccount(cuser,cbal);
                        currentAccount.CalculateInterest();
                        Console.WriteLine("Maintenance fee(50/-) will be deducted from your balance.");
                        AccountManager accountManager1 = new AccountManager();
                        accountManager1.ApplyMaintenanceFee(50, currentAccount.Balance);
                        break;
                    case "3":
                        Console.WriteLine("Exit Now");
                        temp = 1;
                        break;
                }
                
            } while (temp==0);
        }
    }
}













