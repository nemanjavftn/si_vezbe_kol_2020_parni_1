using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness
    {
        ProductRepository pr;
        public ProductBusiness()
        {
            this.pr = new ProductRepository();
        }

        public List<Product> GetProducts()
        {
            return pr.GetAllProducts();
        }
        public bool InsertProduct(Product p)
        {
            int result = pr.InsertProduct(p);
            if (result != 0)
            return true;
            else
            return false;
        }

    }
}
