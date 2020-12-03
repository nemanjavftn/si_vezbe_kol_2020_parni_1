using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness
    {
        private readonly ProductRepository productRepository;
        
        public ProductBusiness()
        {
            this.productRepository = new ProductRepository();
        }
        public List<Product> GetAllProducts()
        {
            return this.productRepository.GetAllProducts();
        }
        public bool InsertProduct(Product p)
        {
            if (this.productRepository.InsertProduct(p) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
