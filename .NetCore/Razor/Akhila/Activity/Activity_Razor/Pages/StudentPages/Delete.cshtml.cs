using Activity_Razor.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Activity_Razor.Model;
using Activity_Razor.Service;


namespace Activity_Razor.Pages.StudentPages
{
    public class DeleteModel : PageModel
    {
        private readonly StudentService _service;
        [BindProperty]
        public Student student { get; set; } = new Student();
        public DeleteModel(StudentService service)
        {
            _service = service;
        }
       
       
        public async Task<IActionResult> OnGetsync(int id)
        {
            student =await _service.GetStudentByIdAsync(id);
            if (student == null)
                return NotFound();
            return Page();
        }
        public async Task<IActionResult> OnPostsync(int id)
        {
            await _service.DeleteStudentByIdAsync(id);
            return RedirectToPage("Index");
        }
    }
}
