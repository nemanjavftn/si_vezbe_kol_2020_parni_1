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

        public List<Product> GetAllStudents()
        {
            return this.productRepository.GetAllProducts();
        }

        public List<Product> GetProductsDateTime(decimal averageMark)
        {
            return this.studentRepository.GetAllStudents()
                .Where(s => s.AverageMark > averageMark).ToList();
        }



    }
}
