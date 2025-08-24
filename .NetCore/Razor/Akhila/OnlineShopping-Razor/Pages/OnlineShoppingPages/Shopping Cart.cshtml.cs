using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineShopping_Razor.Model;
using OnlineShopping_Razor.Services;

namespace OnlineShopping_Razor.Pages.OnlineShoppingPages
{
    public class Shopping_CartModel : PageModel
    {
        private readonly OnlineServices _services;
        [BindProperty]
        public IList<Product> GetProducts { get; set; } = new List<Product>();
        public Shopping_CartModel(OnlineServices services)
        {
            _services = services;
        }
        public async Task OnGetAsync()
        {
            GetProducts = await _services.GetCartProducts();
        }
        public void OnGet()
        {
        }
    }
}
