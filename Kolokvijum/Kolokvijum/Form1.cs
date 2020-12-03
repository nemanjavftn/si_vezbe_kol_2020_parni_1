using BusinessLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokvijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductBusiness pb = new ProductBusiness();
            List<Product> list = new List<Product>();
            list = pb.GetProducts();
            foreach(Product p in list)
            {
                listBox1.Items.Add(p.ToString());
            }
            foreach (Product p in list)
            {
                listBox2.Items.Add(p.toString2());
            }
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            ProductBusiness pb = new ProductBusiness();
            List<Product> list = pb.GetProducts();
            DateTime d = dateTimePicker1.Value;
            Product p = new Product(Convert.ToInt32(textBoxID.Text), textBoxNAME.Text, textBoxDESC.Text, d);
            if (pb.InsertProduct(p) == true)
            {
                MessageBox.Show("VALID");
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                Form1_Load(null, null);
            }
            else
                MessageBox.Show("INVALID");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
