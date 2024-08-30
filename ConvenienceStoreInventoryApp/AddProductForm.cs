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
            UpdatedProducts = product;

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
            if (Validator.ValidTextInput(txtProductName.Text, txtPrice.Text, 
                txtQuantity.Text, txtCategory.Text, txtDescription.Text))
            {
                //Get info from the form
                try
                {
                    if (isUpdateMode)
                    {
                        UpdatedProducts.Name = txtProductName.Text;
                        UpdatedProducts.Price = double.Parse(txtPrice.Text);
                        UpdatedProducts.Quantity = double.Parse(txtQuantity.Text);
                        UpdatedProducts.Categories = txtCategory.Text;
                        UpdatedProducts.Description = txtDescription.Text;

                        ProductDb.Update(UpdatedProducts);
                        MessageBox.Show("Product Updated Successfully!");
                    }
                    else
                    {
                        string name = txtProductName.Text;
                        string price = txtPrice.Text;
                        string quantity = txtQuantity.Text;
                        string category = txtCategory.Text;
                        string description = txtDescription.Text;

                        Products newProduct = new Products(name, double.Parse(price), 
                                       double.Parse(quantity), category, description);
                        ProductDb.Add(newProduct);
                        MessageBox.Show("Product Add Successfully!");
                    }
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding product: Server issues");
                }
            }
            else
            {
                return;
            }
        }
    }
}

