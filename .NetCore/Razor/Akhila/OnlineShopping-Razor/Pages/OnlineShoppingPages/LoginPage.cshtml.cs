using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineShopping_Razor.Services;

namespace OnlineShopping_Razor.Pages.OnlineShoppingPages
{
    public class LoginPageModel : PageModel
    {
        private readonly OnlineServices _services;
        private readonly IHttpContextAccessor _contextAccessor;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public LoginPageModel(OnlineServices services,IHttpContextAccessor contextAccessor)
        {
            _services= services;
            _contextAccessor= contextAccessor;
        }
        public async Task<IActionResult> OnPostAsync()
        {

            if (await _services.VerifyUser(Username, Password))
            {
                //HttpContext.Session.SetString("User", Username);
                _contextAccessor.HttpContext.Session.SetString("User", Username);
                return RedirectToPage("Index");

            }
            ModelState.AddModelError("", "Invalid UserName and Password");
            return Page();


            //if (!ModelState.IsValid) 
            //{
            //    return Page();
            //}

            //if (await _services.VerifyUser(Username, Password))
            //{

            //    _contextAccessor.HttpContext.Session.SetString("User", Username);
            //    return RedirectToPage("Index"); 
            //}
            //else
            //{
            //    ModelState.AddModelError("", "Invalid Username or Password"); 
            //    return Page(); 
            //}

        }
        public void OnGet()
        {
        }
    }
}
