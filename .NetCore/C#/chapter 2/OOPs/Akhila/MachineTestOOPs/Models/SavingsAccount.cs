using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestOOPs.Models
{
    public class SavingsAccount : Account
    {
        
            public double savingsInterest { get; set; }
            public SavingsAccount(string accountHolder, double balance, double savingsInterest) : base(accountHolder, balance)
            {

                this.savingsInterest = 0.05;
            }

            public override void CalculateInterest()
            {
                Balance += (Balance * savingsInterest);
            }
   
    }
}
