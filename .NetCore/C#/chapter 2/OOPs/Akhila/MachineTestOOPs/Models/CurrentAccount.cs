using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestOOPs.Models
{
    public class CurrentAccount:Account
    {
        public CurrentAccount(string accountHolder, double balance) : base(accountHolder, balance)
         { }

        public override void CalculateInterest()
        {
              Console.WriteLine("For current account,no interest.Balance:{0}",Balance);

        }
    }
}
