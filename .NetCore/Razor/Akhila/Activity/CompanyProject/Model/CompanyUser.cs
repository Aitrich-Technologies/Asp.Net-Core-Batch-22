using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Model
{
    public class CompanyUser
    {
        [Key]
        public int userId { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int userStatus { get; set; }
    }
}
