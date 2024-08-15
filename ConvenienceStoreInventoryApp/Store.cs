using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConvenienceStoreInventoryApp.Form1;

namespace ConvenienceStoreInventoryApp
{
    public class Store
    {
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
            return Products.Find(p =>
                (name == null || p.Name == name) &&
                (category == null || p.Category == category) &&
                (price == null || p.Price == price));
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
}
