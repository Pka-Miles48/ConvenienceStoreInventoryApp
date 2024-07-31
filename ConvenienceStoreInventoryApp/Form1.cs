namespace ConvenienceStoreInventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> products = new ConvenienceStoreInventoryApp.ProductDb.GetAllProducts();
        }
    }
}
