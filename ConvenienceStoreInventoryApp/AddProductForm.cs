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
            string productName = txtProductName.Text;
            decimal productPrice = Convert.ToDecimal(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            string category = txtCategory.Text;
            string description = txtDescription.Text;

            //Add info into a new product object
            Product product = new Product(productName, productPrice, quantity, category, description);

            //Send object to ProductDb for storage
            ProductDb.Add(product);
        }
    }
}
