using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.Job.DTOs
{
    public class JobPostsDtos
    {
        public Guid Id { get; set; }

        public string JobTitle { get; set; } = null!;

        public string JobSummary { get; set; } = null!;

        //public string LocationName { get; set; }
        //public string IndustryName { get; set; }
        //public string CategoryName { get; set; }

        public string PostedBy { get; set; }

        public DateTime PostedDate { get; set; }

        //public bool Saved { get; set; }
    }
}
