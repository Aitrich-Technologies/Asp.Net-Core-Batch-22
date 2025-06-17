using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_CollExcLinq.Models
{
    public class Customer
    {
        public string HolderName {  get; set; }
        public string userid { get; set; }
        public string passsword {  get; set; }
        public string user_type { get;set; }
        public int accountno { get; set; }
        public string Phone {  get; set; }

        public Customer() { }
        public Customer(string name, string userid,string password,string user,string phone)
        {
            this.HolderName= name;
            this.userid = userid;
            this.passsword = password;
            this.user_type= user;
            this.Phone = phone;
        }
        public Customer(string holderName, string userid, string passsword, int accountno,string phn)
        {
            this.HolderName = holderName;
            this.userid = userid;
            this.passsword = passsword;
            this.accountno = accountno;
            this.Phone = phn;
        }
    }
}
