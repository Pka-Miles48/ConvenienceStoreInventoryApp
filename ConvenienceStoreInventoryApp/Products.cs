using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStoreInventoryApp
{
    public class Product
    {
        // Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Constructor for the Products
        /// </summary>
        /// <param name="id">The id number of the product non settable</param>
        /// <param name="name">The name of the product</param>
        /// <param name="price">The price of the product</param>
        /// <param name="quantity">The amount of items for the product</param>
        public Product(int id, string name, decimal price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Method to display product details
        public void DisplayProductInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity: {Quantity}");
        }

        // Method to update quantity
        public void UpdateQuantity(int amount)
        {
            Quantity += amount;
        }
    }

}
