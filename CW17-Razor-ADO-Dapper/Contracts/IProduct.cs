using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    internal interface IProduct
    {
        void CreateProduct(Product product);
        List<Product> GetProducts();
        Product GetProduct(int productId);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
