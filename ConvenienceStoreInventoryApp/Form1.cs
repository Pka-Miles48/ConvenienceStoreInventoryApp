namespace ConvenienceStoreInventoryApp
{ 
    public partial class Form1 : Form
    {
        private Store store = new Store();

        public Form1()
        {
            InitializeComponent();
        }

        public class Store
        {
            // Define the properties and methods for the Store class here
            // For example:
            public List<Product> Products { get; set; }

            public Store()
            {
                Products = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                Products.Add(product);
            }

            public void UpdateProduct(int id, string name, string category, decimal price, int stock)
            {
                var product = Products.Find(p => p.Id == id);
                if (product != null)
                {
                    product.Name = name;
                    product.Category = category;
                    product.Price = price;
                    product.Stock = stock;
                }
            }

            public Product LookupProduct(string? name = null, string? category = null, decimal? price = null)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return Products.Find(p =>
                    (name == null || p.Name == name) &&
                    (category == null || p.Category == category) &&
                    (price == null || p.Price == price));
#pragma warning restore CS8603 // Possible null reference return.
            }

            public void ProcessSale(int productId, int quantity)
            {
                var product = Products.Find(p => p.Id == productId);
                if (product != null && product.Stock >= quantity)
                {
                    product.Stock -= quantity;
                    Console.WriteLine($"Sold {quantity} of {product.Name}");
                }
                else
                {
                    Console.WriteLine("Insufficient stock or product not found.");
                }
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }
            public int Id { get; internal set; }

            // You can add more properties if needed
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new product instance
                var product = new Product
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtName.Text,
                    Category = txtCategory.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                // Add the product to the store's inventory
                store.AddProduct(product);

                // Display a success message
                MessageBox.Show("Product added successfully!");

                // Clear the input fields
                txtId.Clear();               
                txtName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();
                txtStock.Clear();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error adding product: {ex.Message}");
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the product in the store's inventory
                store.UpdateProduct(
                    int.Parse(txtId.Text),
                    txtName.Text,
                    txtCategory.Text,
                    decimal.Parse(txtPrice.Text),
                    int.Parse(txtStock.Text)
                );

                // Display a success message
                MessageBox.Show("Product updated successfully!");

                // Clear the input fields
                txtId.Clear();
                txtName.Clear();
                txtCategory.Clear();
                txtPrice.Clear();
                txtStock.Clear();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private void btnLookupProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Lookup the product in the store's inventory
                var product = store.LookupProduct(name: txtName.Text);

                if (product != null)
                {
                    // Display the product details in the input fields
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
                // Display an error message if something goes wrong
                MessageBox.Show($"Error looking up product: {ex.Message}");
            }
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            try
            {
                // Process the sale in the store's inventory
                int productId = int.Parse(txtId.Text);
                int quantity = int.Parse(txtQuantity.Text);

                store.ProcessSale(productId, quantity);

                // Display a success message
                MessageBox.Show("Sale processed successfully!");

                // Clear the input fields
                txtId.Clear();
                txtQuantity.Clear();
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error processing sale: {ex.Message}");
            }
        }
    }
}
