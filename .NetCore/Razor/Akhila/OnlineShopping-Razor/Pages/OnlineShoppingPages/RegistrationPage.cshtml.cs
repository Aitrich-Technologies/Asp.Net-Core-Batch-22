using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShopping_Razor.Model;
using OnlineShopping_Razor.Services;

namespace OnlineShopping_Razor.Pages.OnlineShoppingPages
{
    public class RegistrationPageModel : PageModel
    {
        private readonly OnlineServices _service;
        [BindProperty]
        public OnlineUser newuser { get; set; }
        public RegistrationPageModel(OnlineServices service)
        {
            _service=service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(string.IsNullOrEmpty(newuser.username)||string.IsNullOrEmpty(newuser.password))
            {
                ModelState.AddModelError("", "UserName and Passwors Required");
                return Page();
            }
            await _service.AddNewUserAsync(newuser);
            return RedirectToPage("LoginPage");
        }
        public void OnGet()
        {
        }
    }
}
