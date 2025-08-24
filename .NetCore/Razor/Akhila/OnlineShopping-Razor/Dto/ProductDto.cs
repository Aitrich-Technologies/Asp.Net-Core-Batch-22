using System.ComponentModel.DataAnnotations;

namespace OnlineShopping_Razor.Dto
{
    public class ProductDto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
    


    }
}
