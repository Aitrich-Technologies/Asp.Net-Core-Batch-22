using LibrarySystem.Dto;
using LibrarySystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library
{
    public class NewBookModel : PageModel
    {
        private readonly LibraryServices libraryServices;
        [BindProperty]public BookDto Newbook { get; set; }=new BookDto();
        public NewBookModel(LibraryServices services)
        {
            libraryServices = services;
        }
        public async Task OnPostAsync()
        {
            await libraryServices.AddNewBookAsync(Newbook);
            RedirectToPage("NewBook");
        }
        public void OnGet()
        {
        }
    }
}
