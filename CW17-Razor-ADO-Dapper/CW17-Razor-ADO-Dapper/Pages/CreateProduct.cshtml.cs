using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW17_Razor_ADO_Dapper.Pages
{
    public class CreateProductModel : PageModel
    {
        [BindProperty]
        public Product NewProduct { get; set; }
        public List<Category> Categories { get; set; }
        
        public void OnGet()
        {
            CategoryServices categoryServices = new CategoryServices();
            Categories = categoryServices.GetCategories();
        }

        public IActionResult OnPost() 
        {
            ProductServices productServices = new ProductServices();
            productServices.CreateProduct(NewProduct);
            return RedirectToPage("Index");
        }
    }
}
