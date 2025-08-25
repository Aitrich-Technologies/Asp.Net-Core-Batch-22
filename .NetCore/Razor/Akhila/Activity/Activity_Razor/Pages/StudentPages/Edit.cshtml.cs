using Activity_Razor.Service;
using Activity_Razor.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Activity_Razor.Pages.StudentPages
{
    public class EditModel : PageModel
    {
        public readonly StudentService _service;
        [BindProperty]
        public Student GetStudent { get; set; }
        public EditModel(StudentService service)
        {
            _service = service;
        }
        public async Task<IActionResult> OnGetAsync(int Id)
        {
            var StudentDto= await _service.GetStudentByIdAsync(Id);
            if (StudentDto == null)
                return NotFound();
            GetStudent = StudentDto;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _service.UpdateStudentByIdAsync(GetStudent.Id, GetStudent);
            return RedirectToPage("Index");
        }
                
    }
}
