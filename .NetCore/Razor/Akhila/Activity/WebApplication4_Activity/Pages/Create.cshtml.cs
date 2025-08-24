using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication4_Activity.Model;
using WebApplication4_Activity.Service;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4_Activity.Pages
{
    public class CreateModel : PageModel
    {
        private readonly StudentService _service;
        [BindProperty]

        public Student student { get; set; }
        public CreateModel(StudentService service)
        {
            _service = service;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            //await _service.AddStudentAsync(student);
            return RedirectToPage("ViewStudent");
        }
                public void OnGet()
                {
                }
    }
}
