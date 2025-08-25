using LibrarySystem.Model;
using LibrarySystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace LibrarySystem.Pages.Library
{
    public class IndexModel : PageModel
    {
        private readonly LibraryServices _libraryService;
       private readonly IHttpContextAccessor _contextAccessor;
        [BindProperty] public string? Role { get; set; }
        [BindProperty] public string? Password { get; set; }
        public LibraryRole libraryRole{ get; set; }
        public IndexModel(LibraryServices services, IHttpContextAccessor contextAccessor)
        {
            _libraryService = services;
            _contextAccessor = contextAccessor;    
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (await _libraryService.ValidateRoleAsync(Role, Password))
            {
                _contextAccessor.HttpContext.Session.SetString("Role", Role);
                _contextAccessor.HttpContext.Session.SetString("Password", Password);
                if (Role == "Admin" && Password == "123")
                {
                    return RedirectToPage("AdminPage");
                }
                else
                    return RedirectToPage("UserPage");
            }
            else
                return Page();
        }

        public void OnGet()
        {
        }
    }
}
