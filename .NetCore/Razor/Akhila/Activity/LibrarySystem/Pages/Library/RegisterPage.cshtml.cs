using LibrarySystem.Model;
using LibrarySystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library
{
    public class RegisterPageModel : PageModel
    {
        private readonly LibraryServices _services;
        [BindProperty]
        public LibraryRole libraryRole { get; set; } = new LibraryRole();
        public RegisterPageModel(LibraryServices services)
        {
            _services = services;
        }


        public async Task<IActionResult> OnPostAsync()
        {

            if (libraryRole == null || string.IsNullOrEmpty(libraryRole.UserRole) || string.IsNullOrEmpty(libraryRole.Password))
            {
                ModelState.AddModelError("", "UserRole and Password not matching");
                return Page();
            }
            else
            {
                await _services.AddNewUserAsync(libraryRole.UserRole, libraryRole.Password);
                return RedirectToPage("Index");
            }
        }
        public void OnGet()
        {
        }
    }
}
