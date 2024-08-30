using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStoreInventoryApp
{
    /// <summary>
    /// Represents a product in the store's inventory.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity of the product.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Gets or sets the ID of the product.
        /// </summary>
        public int Id { get; internal set; }
    }
}
