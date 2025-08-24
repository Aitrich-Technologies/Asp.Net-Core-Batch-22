using LibrarySystem.Dto;
using LibrarySystem.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;

namespace LibrarySystem.Pages.Library
{
    public class UserPageModel : PageModel
    {
        private readonly LibraryServices libraryServices;
        [BindProperty]
        public IList<BookDto> GetBooks { get; set; }=new List<BookDto>();
        //[BindProperty] public string UserRole { get; set; }
        public UserPageModel(LibraryServices services)
        {
            libraryServices = services;
        }
       public async Task OnGetAsync()
        {
            GetBooks = await libraryServices.GetAllBooksAsync();
        }
    }
}
