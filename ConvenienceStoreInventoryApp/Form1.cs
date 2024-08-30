using Microsoft.Data.SqlClient;
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
    public partial class Form1 : Form
    {
        private ProductsContext _context;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProducts()
        {
            lstProducts.Items.Clear();
            List<Products> products = ProductDb.GetAllProducts();
            foreach (Products product in products)
            {
                lstProducts.Items.Add(product);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            LoadProducts();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)
            {
                MessageBox.Show("A Product must be selected.");
                return;
            }
            else
            {
                Products selectedProduct = (Products)lstProducts.SelectedItem;

                AddProductForm updateProductForm = new AddProductForm(selectedProduct);
                updateProductForm.ShowDialog();
            }
            LoadProducts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)
            {
                MessageBox.Show("A Product must be selected.");
                return;
            }

            Products selectedProduct = (Products)lstProducts.SelectedItem;

            try
            {
                ProductDb.Delete(selectedProduct);
                MessageBox.Show($"{selectedProduct.Name} was deleted successfully!");
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
        }
    }
}
