using System.ComponentModel.DataAnnotations;

namespace Exercise_Blazor.Model
{
    public class JobDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string JobDescription { get; set; }
        [Required]
        public decimal Salary {  get; set; }
        [Required]
        public int Experience {  get; set; }
        [Required]
        public string TypeofWork {  get; set; }
        [Required]
        public string Location {  get; set; }
    }
}
