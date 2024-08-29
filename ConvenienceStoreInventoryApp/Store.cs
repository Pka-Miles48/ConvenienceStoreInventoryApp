using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConvenienceStoreInventoryApp.Form1;

namespace ConvenienceStoreInventoryApp
{
    /// <summary>
    /// Represents a store that contains a list of products.
    /// </summary>
    public class Store
    {
        private object products;

        /// <summary>
        /// Gets or sets the list of products in the store.
        /// </summary>
        public List<Product> Products { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Store"/> class.
        /// </summary>
        public Store()
        {
            Products = new List<Product>();
        }

        /// <summary>
        /// Adds a product to the store's inventory.
        /// </summary>
        /// <param name="product">The product to add.</param>
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        /// <summary>
        /// Updates the details of an existing product in the store's inventory.
        /// </summary>
        /// <param name="id">The ID of the product to update.</param>
        /// <param name="name">The new name of the product.</param>
        /// <param name="category">The new category of the product.</param>
        /// <param name="price">The new price of the product.</param>
        /// <param name="stock">The new stock quantity of the product.</param>
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

        /// <summary>
        /// Looks up a product in the store's inventory based on the specified criteria.
        /// </summary>
        /// <param name="name">The name of the product to look up (optional).</param>
        /// <param name="category">The category of the product to look up (optional).</param>
        /// <param name="price">The price of the product to look up (optional).</param>
        /// <returns>The product that matches the specified criteria, or null if no match is found.</returns>
        public Product LookupProduct(string? name = null, string? category = null, decimal? price = null)
        {
            return Products.Find(p =>
                (name == null || p.Name == name) &&
                (category == null || p.Category == category) &&
                (price == null || p.Price == price));
        }

        /// <summary>
        /// Processes a sale by reducing the stock quantity of the specified product.
        /// </summary>
        /// <param name="productId">The ID of the product to sell.</param>
        /// <param name="quantity">The quantity to sell.</param>
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

        public List<Product> GetProducts()
        {
            return (List<Product>)products;
        }

        internal IEnumerable<object> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}