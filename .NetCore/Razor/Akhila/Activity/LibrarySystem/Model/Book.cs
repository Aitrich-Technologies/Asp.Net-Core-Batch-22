using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
