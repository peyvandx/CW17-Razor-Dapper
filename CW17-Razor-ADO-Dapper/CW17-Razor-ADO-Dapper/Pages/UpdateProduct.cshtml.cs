using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW17_Razor_ADO_Dapper.Pages
{
    public class UpdateProductModel : PageModel
    {
        [BindProperty]
        public Product UpdatedProduct { get; set; }
        public List<Category> Categories { get; set; }

        public void OnGet(int productId)
        {
            ProductServices productServices = new ProductServices();
            CategoryServices categoryServices = new CategoryServices();
            UpdatedProduct = productServices.GetProduct(productId);
            Categories = categoryServices.GetCategories();
        }

        public IActionResult OnPost()
        {
            ProductServices productServices = new ProductServices();
            productServices.UpdateProduct(UpdatedProduct);
            return RedirectToPage("Index");
        }
    }
}
