using System.ComponentModel.DataAnnotations;

namespace OnlineShopping_Razor.Model
{
    public class OnlineUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
