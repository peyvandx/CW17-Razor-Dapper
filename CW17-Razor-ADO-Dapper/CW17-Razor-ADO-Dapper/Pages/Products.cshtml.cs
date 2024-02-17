using Contracts;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW17_Razor_ADO_Dapper.Pages
{
    public class ProductsModel : PageModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }


        public void OnGet()
        {
            ProductServices productServices = new ProductServices();
            CategoryServices categoryServices = new CategoryServices();
            Products = productServices.GetProducts();
            Categories = categoryServices.GetCategories();
        }

        public void OnPost() { }
    }
}
