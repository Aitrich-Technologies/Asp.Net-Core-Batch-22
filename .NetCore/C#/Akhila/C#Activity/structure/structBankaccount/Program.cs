using System.Reflection.Metadata.Ecma335;

namespace Bankaccount
{
    struct Bankaccount
    {
        public int acctnumber;
        public string accholdrname;
        public int balance;
    };
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            Bankaccount[] bankaccounts=new Bankaccount[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Details of account {i + 1}:");
                Console.WriteLine("Account No.");
                bankaccounts[i].acctnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Holder Name:");
                bankaccounts[i].accholdrname = Console.ReadLine();
                Console.WriteLine("Balance:");
                bankaccounts[i].balance = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter account number");
            int bankacc=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the action Deposit/Withdrawal:(D/W):  ");
            string action = Console.ReadLine();
            Console.WriteLine("Enter the amount:  ");
            int amount=Convert.ToInt32(Console.ReadLine());

                
                    if (action == "D" || action == "d")
                    {
                         deposit(bankacc, amount);
                    }
                    else if((action == "W" || action == "w"))
                    {
                         withdrawal(bankacc, amount);
                    }
                    else
                    {
                        Console.WriteLine("Enter action properly");
                    }
                
                void deposit(int numb, int amt)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (bankaccounts[i].acctnumber==numb)
                        {
                            bankaccounts[i].balance +=amt;
                        Console.WriteLine("Current balance of Name:{0} is {1}", bankaccounts[i].accholdrname, bankaccounts[i].balance);
                        break;
                        }
                    }
                }

                void withdrawal(int numb, int amt)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (bankaccounts[i].acctnumber == numb)
                        {
                            bankaccounts[i].balance -= amt;
                        
                        Console.WriteLine("Current balance of Name:{0} is {1}", bankaccounts[i].accholdrname, bankaccounts[i].balance);
                        break;
                    }
                    }
                }

        }
    }
}
