
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentscoringsystem.Models
{
    public class student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }

        public student() { }
        public student(int iD, string name, int age, int score)
        {
            ID = iD;
            Name = name;
            Age = age;
            Score = score;
        }
    }
}
