
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Workshop4_CollExcpLinq.Enums;

namespace Workshop4_CollExcpLinq.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public Roles Role { get; set; }
        public User() { }
        public User(int id, string Fname, string Lname, string email, string password,string phone,Roles role)
        {
            Id = id;
            FirstName = Fname;
            LastName = Lname;
            Email = email;
            Password = password;
            Phone = phone;
            Role = role;

        }
    }
}
