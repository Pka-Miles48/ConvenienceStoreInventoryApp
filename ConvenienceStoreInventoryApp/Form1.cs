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

            // Add methods for adding products, updating products, etc.
        }

        public class Product
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public decimal Price { get; set; }
            public int Stock { get; set; }

            // You can add more properties if needed
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Add product logic
            AddProductForm addProduct = new AddProductForm();
            addProduct.ShowDialog();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Update product logic
        }

        private void btnLookupProduct_Click(object sender, EventArgs e)
        {
            // Lookup product logic
        }

        private void btnProcessSale_Click(object sender, EventArgs e)
        {
            // Process sale logic
        }
    } 
}
