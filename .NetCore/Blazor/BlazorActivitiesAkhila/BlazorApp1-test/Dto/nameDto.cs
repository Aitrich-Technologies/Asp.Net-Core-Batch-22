using System.ComponentModel.DataAnnotations;

namespace BlazorApp1_test.Dto
{
    public class nameDto
    {
        [Required]
        public string Name { get; set; }
    }
}
