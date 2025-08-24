using System.ComponentModel.DataAnnotations;

namespace WebApplication4_Activity.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        public string Course { get; set; }
    }
}
