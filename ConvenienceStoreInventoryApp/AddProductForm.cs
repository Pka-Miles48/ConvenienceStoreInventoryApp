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
        private bool isUpdateMode;
        private Products UpdatedProducts;
        public AddProductForm()
        {
            InitializeComponent();
            isUpdateMode = false; //Default mode is add mode
        }

        public AddProductForm(Products product)
        {
            InitializeComponent();
            isUpdateMode = true; //Set to update mode

            btnAddProduct.Text = "Update Product";
            Text = "Update Product";

            txtProductName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            txtCategory.Text = product.Categories;
            txtDescription.Text = product.Description;
                        
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

            if (isUpdateMode)
            {
                ProductDb.Update(p);
                MessageBox.Show("Product Updated Successfully!");
                Close();
            }
            else
            {
                ProductDb.Add(p);
                MessageBox.Show("Product Add Successfully!");
                Close();
            }
        }
    }
}
