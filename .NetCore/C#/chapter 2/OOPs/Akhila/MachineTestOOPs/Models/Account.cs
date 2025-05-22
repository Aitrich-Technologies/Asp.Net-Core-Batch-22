using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestOOPs.Models
{
    public abstract class Account
    {
        public string AccountHolder;
        public double Balance;
        public Account(string accountHolder, double balance)
        {
            this.AccountHolder = accountHolder;
            this.Balance = balance;
        }
        public abstract void CalculateInterest();

       
    }
}
