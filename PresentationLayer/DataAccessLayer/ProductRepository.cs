using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> results = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Products";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Product p = new Product();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.Description = sqlDataReader.GetString(2);
                    p.ExpiryDate = sqlDataReader.GetDateTime(3);

                    results.Add(p);
                }
                return results;

            }
            public int InsertProduct(Product p)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText =
                        string.Format("INSERT INTO Students VALUES ('{0}', '{1}', {2})",
                            p.Name, p.Description, p.ExpiryDate);

                    sqlConnection.Open();

                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }

}
