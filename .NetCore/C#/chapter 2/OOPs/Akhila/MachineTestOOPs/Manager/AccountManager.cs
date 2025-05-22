using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MachineTestOOPs.Interface;
using MachineTestOOPs.Manager;
using MachineTestOOPs.Models;

namespace MachineTestOOPs.Manager
{
    public class AccountManager:IMaintenanceFee
    {
        SavingsAccount savingsAccount;
        CurrentAccount currentAccount;
        public AccountManager()
        { }
        public void ApplyMaintenanceFee(double fee,double balance)
        {
            if (balance > fee) 
            {
                balance -= fee;
                Console.WriteLine("Your current Balance :{0}", balance);
            }
        }   

        //public void CApplyMaintenanceFee(double cfee,double balan)
        //{
        //    if(balan> cfee)
        //    {
        //        balan-= cfee;
        //        Console.WriteLine("Your current Balance :{0}",balan );
        //    }
        //}
    }
}
