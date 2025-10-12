using System.ComponentModel.DataAnnotations;

namespace BlazorApp1_test.Model
{
    public class name
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
