using System.ComponentModel.DataAnnotations;

namespace Exercise_MVC.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? First_Name { get; set; }
        [Required]
        public string? Last_Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public long Phone_Number { get; set;  }
        [Required]
        public string? Password { get; set;  }
        [Required]
        public string? Confirm_Password { get; set;  }
       
        public string? Gender { get; set;  }
        public string Skills { get; set;  }
        public string Education { get; set;  }
        public string Experience { get; set;  }
        public string Aboutme { get; set;  }
    }
}
