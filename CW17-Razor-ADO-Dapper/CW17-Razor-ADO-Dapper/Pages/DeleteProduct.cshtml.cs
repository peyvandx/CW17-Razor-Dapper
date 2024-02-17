using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW17_Razor_ADO_Dapper.Pages
{
    public class DeleteProductModel : PageModel
    {
        [BindProperty]
        public int DeletedProductId { get; set; }
        public List<Product> Products { get; set; }
        ProductServices productServices = new ProductServices();
        public void OnGet()
        {
            Products = productServices.GetProducts();
        }

        public IActionResult OnPost() 
        {
            productServices.DeleteProduct(DeletedProductId);
            return RedirectToPage("Index");
        }
    }
}
