using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        //[Display(Name = "Name: ")]
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }


    }
}
