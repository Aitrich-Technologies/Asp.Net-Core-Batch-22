using System.ComponentModel.DataAnnotations;

namespace Blazor_MachineTest.Model
{
    public class Pet
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string imagepath { get; set; }

    }
}
