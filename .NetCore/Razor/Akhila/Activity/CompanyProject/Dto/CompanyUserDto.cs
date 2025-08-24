using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Dto
{
    public class CompanyUserDto
    {
       
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        
    }
}
