using System.ComponentModel.DataAnnotations;

namespace Exercise_MVC.Models
{
    public class Job
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Skills { get; set;  }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Location { get; set;  }
        [Required]
        public long Salary { get; set; }

    }
}
