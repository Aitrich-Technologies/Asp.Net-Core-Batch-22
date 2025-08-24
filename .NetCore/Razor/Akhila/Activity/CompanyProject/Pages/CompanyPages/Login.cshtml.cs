using CompanyProject.Model;
using CompanyProject.Services;
using CompanyProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyProject.Pages.CompanyPages
{
    public class LoginModel : PageModel
    {
        private readonly CompanyServices _companyServices;
        private readonly IHttpContextAccessor _contextAccessor;
      
        public CompanyUser NewUser { get; set; }
        [BindProperty]
        public string? UserName{get;set;}
        [BindProperty]
        public string? Password{get;set;}
        public LoginModel(CompanyServices companyService,IHttpContextAccessor contextAccessor)
        {
            _companyServices = companyService;
            _contextAccessor = contextAccessor;
        }
        public async Task OnPostAsync()
        {

            if (await _companyServices.ValidateUserAsync(UserName, Password))
            {
                _contextAccessor.HttpContext.Session.SetString("Username", UserName);
                _contextAccessor.HttpContext.Session.SetString("Password", Password);
                RedirectToPage("Index");
            }
        }
        public void OnGet()
        {
        }
    }
}
