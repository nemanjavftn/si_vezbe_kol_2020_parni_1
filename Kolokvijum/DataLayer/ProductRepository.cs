using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> ls = new List<Product>();
            string constring = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=ShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string command = "Select * From Products";
            SqlCommand com = new SqlCommand(command, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ls.Add(new Product(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetDateTime(3)));
            }
            return ls;
        }
        public int InsertProduct(Product p)
        {
            int result;
            string constring = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=ShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using(SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string command = "Insert Into Products (Name,Description,ExpiryDate) VALUES (@Name,@Description,@ExpiryDate)";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@Name", p.name);
                com.Parameters.AddWithValue("@Description", p.description);
                com.Parameters.AddWithValue("@ExpiryDate", p.date);
                result = com.ExecuteNonQuery();
            }
            return result;
        }
    }
}
