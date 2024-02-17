using Dapper;
using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class ProductServices : IProduct
    {
        const string connectionString = @"Data Source=PEYVAND\SQLEXPRESS;Initial Catalog=CW17;Integrated Security=True;Trust Server Certificate=True";

        public void CreateProduct(Product product)
        {
            const string sql = "INSERT INTO Products (Name, Title, Description, Price, Color, CategoryId) VALUES (@Name, @Title, @Description, @Price, @Color, @CategoryId);";
            using var connection = new SqlConnection(connectionString);
            var command = new CommandDefinition(sql, product);
            connection.Execute(command);
        }

        public void DeleteProduct(int id)
        {
            string sql = $"DELETE FROM Products WHERE ProductId = {id}";
            using var connection = new SqlConnection(connectionString);
            var command = new CommandDefinition(sql, id);
            connection.Execute(command);
        }

        public List<Product> GetProducts()
        {
            const string sql = "select * from Products";
            using var connection = new SqlConnection(connectionString);
            var command = new CommandDefinition(sql);
            var result = connection.Query<Product>(command);
            return result.ToList();
        }

        public Product GetProduct(int productId)
        {
            string sql = $"select * from Products as pro where pro.ProductId = {productId}";
            using var connection = new SqlConnection(connectionString);
            var command = new CommandDefinition(sql);
            var result = connection.Query<Product>(command).ToList();
            return result.FirstOrDefault();
        }

        public void UpdateProduct(Product product)
        {
            string sql = $"UPDATE Products SET Name = '{product.Name}', Title = '{product.Title}', Description = '{product.Description}', Price = {product.Price}, Color = '{product.Color}', CategoryId = {product.CategoryId} WHERE ProductId = {product.ProductId};";
            using var connection = new SqlConnection(connectionString);
            connection.Execute(sql);
        }
    }
}
