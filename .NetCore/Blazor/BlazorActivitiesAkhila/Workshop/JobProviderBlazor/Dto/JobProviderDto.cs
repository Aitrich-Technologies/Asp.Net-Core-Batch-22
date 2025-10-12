using System.ComponentModel.DataAnnotations;

namespace JobProviderBlazor.Dto
{
    public class JobProviderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
