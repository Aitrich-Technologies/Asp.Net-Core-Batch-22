using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4_Activity.Service;
using Microsoft.EntityFrameworkCore;
using WebApplication4_Activity.Model;

namespace WebApplication4_Activity.Pages
{
    public class ViewStudentModel : PageModel
    {
        private readonly StudentService _studentService;
        [BindProperty]
        public List<Student> StudentsList { get; set; }
        public ViewStudentModel(StudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task OnGetAsync()
        {
            StudentsList = (List<Student>) await _studentService.GetAllStudentsAsync();
        }
    }
}
