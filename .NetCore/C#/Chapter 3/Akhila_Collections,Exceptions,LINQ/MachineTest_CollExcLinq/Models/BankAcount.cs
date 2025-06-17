using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_CollExcLinq.Models
{
    public class BankAcount
    {
        private int Account_Number;
        private string Account_Holdername;
        private int Account_Balance;
        private string Account_Type;
        private string Phone_No;

        public BankAcount() { }
        public BankAcount(int number,string name,int balance,string type,string Phn)
        {
            this.Account_Number=number;
            this.Account_Holdername=name;
            this.Account_Balance=balance;
            this.Account_Type=type;
            this.Phone_No=Phn;
        }
        public int AccountNumber
        {
            get { return Account_Number; }
            set {  Account_Number = value; }

        }

        public string AccountHoldername
        {
            get { return Account_Holdername; }
            set { Account_Holdername = value; }
        }

        public int AccountBalance
        {
            get { return Account_Balance; }
            set { Account_Balance = value; }
        }

        public string AccountType
        {   
            get { return Account_Type; }
            set { Account_Type=value; }
        }
        public string PhoneNo
        {
            get { return Phone_No; }
            set {  Phone_No = value; }
        }
    }
}
