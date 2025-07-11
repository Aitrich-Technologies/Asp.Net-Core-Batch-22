﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Admin_Job.Enums.ExperienceLevel;

namespace Admin_Job.Models
{
    public class Job
    {


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }

        public Job(string title, string description, string location, string type, string salary, string company)
        {
          
            Title = title;
            Description = description;
            Location = location;
            Salary = salary;
            Type = type;
            Company = company;
        }
    }

}
