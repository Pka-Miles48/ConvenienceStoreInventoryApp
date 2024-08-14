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

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Amount of product in the inventory
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// The category the product fits in the store
        /// </summary>
        public string Categories { get; set; }

        /// <summary>
        /// A short description of the product
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Unique Product ID
        /// </summary>
        private int _productId;

        /// <summary>
        /// The product ID should be unique.
        /// </summary>
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        /// <summary>
        /// Constructor for the Products
        /// </summary>
        /// <param name="name">The name of the product</param>
        /// <param name="price">The price of the product</param>
        /// <param name="quantity">The amount of items for the product</param>
        public Product(string name, double price, int quantity, string category, string description)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Categories = category;
            Description = description;
        }

        /// <summary>
        /// Method to display product details
        /// </summary>
        public string DisplayProductInfo()
        {
            return $"Product Name: {Name}, Product Price: {Price}, and Quantity: {Quantity}.";
        }


        public override string ToString()
        {
            return DisplayProductInfo();
        }

        public double getProductInventoryValue()
        {
            double price = Price;
            int quantity = Quantity;
            return price * quantity;

        }
    }

}
