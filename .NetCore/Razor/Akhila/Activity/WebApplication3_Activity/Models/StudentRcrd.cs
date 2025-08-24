using System.ComponentModel.DataAnnotations;

namespace WebApplication3_Activity.StudentRecord
{
    public class StudentRcrd
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
