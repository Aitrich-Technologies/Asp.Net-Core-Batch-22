using System.Security.Cryptography.X509Certificates;

namespace BankAccountOOPs
{
    class BankAccount
    {
        public string Accountholder;
        public int Balance;
        

        public BankAccount(string ah, int bal)
        {
            Accountholder = ah;
            Balance = bal;
        }
        public void deposit(int amt)
        {
            this.Balance += amt;
            Console.WriteLine("Deposited amount is {0}.Current Balance :{1} ", amt,Balance);
        }
        public void withdraw(int amt)
        {
            if (Balance >= amt)
            {
                this.Balance -= amt;
                Console.WriteLine("Withdrawal amount is {0}.Current Balance :{1} ", amt,Balance);
            }
            else
            {
                Console.WriteLine("Balance is not efficient for withdrawal");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankacc1 = new BankAccount("Amrutha", 20000);
            int amount;
            bankacc1.deposit(1000);
            bankacc1.withdraw(2000);
            //Console.WriteLine("Hello, World!");
        }
    }
}
