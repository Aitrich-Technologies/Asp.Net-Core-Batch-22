using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4_CollExcpLinq.Models
{
    public class Applications
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Experience { get; set; }
        public string Qualification { get; set; }
        public string Location {  get; set; }
        public Applications() { }
        public Applications(int id, string name, string experience, string qualification, string location)
        {
            Id = id;
            Name = name;
            Experience = experience;
            Qualification = qualification;
            Location = location;
        }
    }
}
