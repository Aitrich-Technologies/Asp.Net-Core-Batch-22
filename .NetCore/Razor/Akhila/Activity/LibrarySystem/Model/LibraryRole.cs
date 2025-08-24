using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Model
{
    public class LibraryRole
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserRole { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
