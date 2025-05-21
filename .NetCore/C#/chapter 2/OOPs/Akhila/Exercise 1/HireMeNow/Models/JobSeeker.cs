using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HireMeNow.Enums;

namespace HireMeNow.Models
{
    public class JobSeeker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Password { get; set; }

        public JobSeeker() { }
        public JobSeeker(string email,string password)
        {
            Email = email;
            Password = password;
        }

        public JobSeeker(int id, string firstName, string lastName, string email, string phone, string location, string aboutMe, string qualification, ExperienceLevels experienceLevel, string password)
        {
            Id= id;
            FirstName= firstName;
            LastName= lastName;
            Email= email;
            Phone= phone;
            Location= location;
            AboutMe= aboutMe;
            Qualification= qualification;
            ExperienceLevel= experienceLevel;
            Password= password;
        }
    }
}
