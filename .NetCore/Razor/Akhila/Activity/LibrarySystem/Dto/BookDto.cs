using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Dto
{
    public class BookDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; } 
        [Required]
        public string Quantity { get; set; }
    }
}
