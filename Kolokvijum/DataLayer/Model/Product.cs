using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Product
    {
        private int ID;
        private string Name;
        private string Description;
        private DateTime Date;

        public Product(int iD, string name, string description, DateTime date)
        {
            ID = iD;
            Name = name;
            Description = description;
            Date = date;
        }
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string description
        {
            get { return Description; }
            set { Description = value; }
        }
        public DateTime date
        {
            get { return Date; }
            set { Date = value; }
        }
        public override string ToString()
        {
            return $"{ID} {Name} {Description} {Date}";
        }
        public string toString2()
        {
            return $"{ID} {Name}";
        }
    }
}
