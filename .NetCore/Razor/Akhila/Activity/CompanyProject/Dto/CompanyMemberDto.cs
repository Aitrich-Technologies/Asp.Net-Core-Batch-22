using System.ComponentModel.DataAnnotations;

namespace CompanyProject.Dto
{
    public class CompanyMemberDto
    {
        public int memberId { get; set; }
        [Required]
        public string membername { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string mobile { get; set; }
        [Required]
        public string role { get; set; }
       
    }
}
