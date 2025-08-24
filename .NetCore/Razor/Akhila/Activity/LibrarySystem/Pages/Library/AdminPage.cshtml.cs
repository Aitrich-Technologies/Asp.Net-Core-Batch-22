using LibrarySystem.Dto;
using LibrarySystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibrarySystem.Pages.Library
{
    public class AdminPageModel : PageModel
    {
        private readonly LibraryServices libraryServices;
        [BindProperty]
        public IList<BookDto> GetBooks { get; set; } = new List<BookDto>();
        public AdminPageModel(LibraryServices service)
        {
            libraryServices = service;
        }
        //public void OnGet()
        //{
        //}
        public async Task OnGetAsync()
        {
            GetBooks = await libraryServices.GetAllBooksAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id) 
        {
            await libraryServices.GetBookbyIdAsync(id);
           
            return RedirectToPage("AdminPage");
        }
    }
}
