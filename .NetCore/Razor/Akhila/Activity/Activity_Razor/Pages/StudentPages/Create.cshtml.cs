using Activity_Razor.Model;
using Activity_Razor.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Activity_Razor.Pages.StudentPages
{
    public class CreateModel : PageModel
    {
        private readonly StudentService _Service;
        [BindProperty]
        public Student student { get; set; }
        public CreateModel(StudentService service)
        {
            _Service=service;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();
            await _Service.AddStudentAsync(student);
            return RedirectToPage("ViewStudent");
        }
        public void OnGet()
        {
        }
    }
}
