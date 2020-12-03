using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly ProductBusiness productBusiness;
        public Form1()
        {
            InitializeComponent();
            this.productBusiness = new ProductBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
           Product p = new Product();
            p.Name = textBoxName.Text;
            p.Description = textBoxDescription.Text;
            p.ExpiryDate = textBoxExpiryDate.Text;

            if (this.productBusiness.InsertProduct(p))
            {
                RefreshData();
                textBoxName.Text = "";
                textBoxDescription.Text = "";
                textBoxExpiryDate.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }
        private void RefreshData()
        {
            List<Product> products = this.productBusiness.GetAllProducts();
            listBoxProducts.Items.Clear();

            foreach (Product p in products)
            {
                listBoxProducts.Items.Add(p.Id + ". " + p.Name + ", " + p.Description + ", " +
                    p.ExpiryDate + ".");
            }
        }
    }
}
