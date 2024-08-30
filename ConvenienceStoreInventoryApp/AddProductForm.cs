using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStoreInventoryApp
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Get info from the form
            Products? p = null;
            try
            {
                p = new Products(txtProductName.Text, double.Parse(txtPrice.Text), 
                    double.Parse(txtQuantity.Text), txtCategory.Text, txtDescription.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating product: " + ex.Message);
                return;
            }

            ProductsContext context = new ProductsContext();
            context.Products.Add(p);
            context.SaveChanges();


        }
    }
}
