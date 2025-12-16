using System.ComponentModel.DataAnnotations;

namespace JobPortal.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Title { get;set;  }
        public string Description { get; set; }
        public string Location { get; set;  }
        public double Salary { get;set;  }
    }
}
