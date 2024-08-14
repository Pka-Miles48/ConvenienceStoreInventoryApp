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
            btnAddProduct.Enabled = false; //Disables add button until valid data is entered
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Get info from the form
            string productName = txtProductName.Text;
            TextBox productPrice = txtPrice;
            TextBox productQuantity = txtQuantity;
            string category = txtCategory.Text;
            string description = txtDescription.Text;

            double price = Validator.ValidNumberInTextbox(productPrice);
            double quantity = Validator.ValidNumberInTextbox(productQuantity);

            if (Validator.ValidTextInput(productName, price, quantity, category, description) )
            {
                //Add info into a new product object
                Product product = new Product(productName, price, quantity, category, description);

                //Send object to ProductDb for storage
                //ProductDb.Add(product);

                //Show that the product was added to the db
                MessageBox.Show("Added Product Successfully");
                //close window
                Close();
            }
            else
            {
                throw new ArgumentException("Entered invalid information.");
            }
            

            




            
        }
    }
}
