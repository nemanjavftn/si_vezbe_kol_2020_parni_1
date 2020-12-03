using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Product
    {
        private int id { get; set; }
        private String Name { get; set; }
        private String Description { get; set; }
        private DateTime ExpiryDate { get; set; }
    }
}
