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
    public class CategoryServices : ICategory
    {
        const string connectionString = @"Data Source=PEYVAND\SQLEXPRESS;Initial Catalog=CW17;Integrated Security=True;Trust Server Certificate=True";

        public List<Category> GetCategories()
        {
            const string sql = "select * from Categories";
            using var connection = new SqlConnection(connectionString);
            var command = new CommandDefinition(sql);
            var result = connection.Query<Category>(command);
            return result.ToList();
        }
    }
}
