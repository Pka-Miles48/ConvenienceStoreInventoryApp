namespace ConvenienceStoreInventoryApp
{
    public partial class Form1 : Form
    {
        private Store store = new Store();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Category = txtCategory.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                store.AddProduct(product);
                MessageBox.Show("Product added successfully!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                store.UpdateProduct(
                    int.Parse(txtId.Text),
                    txtName.Text,
                    txtCategory.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtStock.Text)
                );

                MessageBox.Show("Product updated successfully!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private void btnLookupProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var product = store.LookupProduct(name: txtName.Text);

                if (product != null)
                {
                    txtId.Text = product.Id.ToString();
                    txtCategory.Text = product.Category;
                    txtPrice.Text = product.Price.ToString();
                    txtStock.Text = product.Stock.ToString();
                    MessageBox.Show("Product found!");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error looking up product: {ex.Message}");
            }
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(txtId.Text);
                int quantity = int.Parse(txtQuantity.Text);

                store.ProcessSale(productId, quantity);
                MessageBox.Show("Sale processed successfully!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing sale: {ex.Message}");
            }
        }

        private void ClearInputFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtQuantity.Clear();
        }
    }
}
