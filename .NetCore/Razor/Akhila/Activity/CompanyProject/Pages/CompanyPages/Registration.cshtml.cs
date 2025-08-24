using CompanyProject.Services;
using CompanyProject.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyProject.Pages
{
    public class RegistrationModel : PageModel
    {
        private readonly CompanyServices _companyService;
        [BindProperty] public CompanyUser NewUser { get; set; }
        public RegistrationModel(CompanyServices companyServices)
        {
            _companyService = companyServices;
        }
        public async Task OnPostAsync()
        {
            await _companyService.AddNewUserAsync(NewUser);
            RedirectToPage("Login");
        }
        public void OnGet()
        {
        }
    }
}