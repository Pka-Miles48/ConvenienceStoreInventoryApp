namespace ConvenienceStoreInventoryApp
{
    public partial class Form1 : Form
    {
        // Create an instance of the Store class to manage the inventory
        private Store store = new Store();

        // Constructor to initialize the form components
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for adding a product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new product with the input values
                var product = new Product
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Category = txtCategory.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                // Add the product to the store
                store.AddProduct(product);
                MessageBox.Show("Product added successfully!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                // Show an error message if adding the product fails
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        // Event handler for updating a product
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the product in the store with the input values
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
                // Show an error message if updating the product fails
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        // Event handler for looking up a product by name
        private void btnLookupProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Look up the product in the store by name
                var product = store.LookupProduct(name: txtName.Text);

                if (product != null)
                {
                    // Display the product details if found
                    txtId.Text = product.Id.ToString();
                    txtCategory.Text = product.Category;
                    txtPrice.Text = product.Price.ToString();
                    txtStock.Text = product.Stock.ToString();
                    MessageBox.Show("Product found!");
                }
                else
                {
                    // Show a message if the product is not found
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                // Show an error message if looking up the product fails
                MessageBox.Show($"Error looking up product: {ex.Message}");
            }
        }

        // Event handler for processing a sale
        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the product ID and quantity from the input fields
                int productId = int.Parse(txtId.Text);
                int quantity = int.Parse(txtQuantity.Text);

                // Process the sale in the store
                store.ProcessSale(productId, quantity);
                MessageBox.Show("Sale processed successfully!");
                ClearInputFields();
            }
            catch (Exception ex)
            {
                // Show an error message if processing the sale fails
                MessageBox.Show($"Error processing sale: {ex.Message}");
            }
        }

        // Event handler for displaying the total price of all products
        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            try
            {
                decimal totalPrice = 0;
                var products = store.GetProducts();

                if (products == null)
                {
                    MessageBox.Show("Products list is null.");
                    return;
                }

                if (products.Count == 0)
                {
                    MessageBox.Show("No products available.");
                    return;
                }

                foreach (var product in products)
                {
                    totalPrice += product.Price * product.Stock;
                }

                MessageBox.Show($"Total price of all products: {totalPrice:C}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total price: {ex.Message}");
            }
        }

        // Method to clear the input fields
        private void ClearInputFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtQuantity.Clear();
        }

        // Event handler for form load
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> products = ProductDb.GetAllProducts();
        }
    }
}
