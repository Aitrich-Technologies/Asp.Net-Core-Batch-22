using Activity_Razor.Model;
using Activity_Razor.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Activity_Razor.Pages.StudentPages
{
    public class ViewStudentModel : PageModel
    {
        private readonly StudentService _studentService;
        [BindProperty]
        public IList<Student> StudentsList { get; set; } = new List<Student>();
        public ViewStudentModel(StudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task OnGetAsync()
        {
            StudentsList = await _studentService.GetAllStudentsAsync();
        }
        //public void OnGet()
        //{
        //}
    }
}
