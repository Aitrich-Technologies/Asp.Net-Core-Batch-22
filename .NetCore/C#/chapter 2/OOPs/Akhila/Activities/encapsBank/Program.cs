using encapsBank;

namespace encapsBank
{
    abstract class BankAccount
    {
        int AccountNumber;
        int Balance;
        public int AcctNum
        {
            get { return AccountNumber; }
            set { AccountNumber = value; }
        }
        
        public int Bal
        {
            get { return Balance; }
            set {Balance = value; }
        }

        public abstract void CalculateInterest();
    }
    class SavingsAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            double interst = Bal * 0.04 * 1;
            Console.WriteLine("Savings account no. {0} interest for 1 year with 4% interest rate will be {1}",AcctNum, interst);
        }
    }
    class CurrentAccount : BankAccount
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Current acccount will not get any interest.Balane:{0}",Bal);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings=new SavingsAccount();
            savings.AcctNum= 1;
            savings.Bal= 10000;
            savings.CalculateInterest();

            CurrentAccount current=new CurrentAccount();
            current.AcctNum = 5;
            current.Bal = 20000;
            
            current.CalculateInterest();
        }
    }
}
