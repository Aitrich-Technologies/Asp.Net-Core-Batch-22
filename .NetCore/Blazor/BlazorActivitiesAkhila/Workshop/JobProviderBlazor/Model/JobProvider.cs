using System.ComponentModel.DataAnnotations;

namespace JobProviderBlazor.Model
{
    public class JobProvider
    {
       [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get; set; }

    }
}
