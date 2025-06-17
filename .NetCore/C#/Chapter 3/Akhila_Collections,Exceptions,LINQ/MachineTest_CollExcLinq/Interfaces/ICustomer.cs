using MachineTest_CollExcLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_CollExcLinq.Interfaces
{
    public interface ICustomer
    {
        void DepositMoney(BankAcount bank);
        void WithdrawMoney(BankAcount bank);
        void CheckBalance(BankAcount bank);
    }
}
