using System.ComponentModel.DataAnnotations;

namespace OnlineShopping_Razor.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
