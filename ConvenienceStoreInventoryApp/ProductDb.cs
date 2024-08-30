using ConvenienceStoreInventoryApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvenienceStoreInventoryApp;

namespace ConvenienceStoreInventoryApp
{
    static public class ProductDb
    {
        static ProductsContext context = new ProductsContext();
        public static void Add(Product product)
        {
            context.Add(product);
            context.SaveChanges();
        }

        public static List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public static void Update(Product product)
        {
            context.Update(product);
            context.SaveChanges();
        }

        public static void Delete(Product product)
        {
            context.Remove(product);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            Product product = GetProduct(id);
            if (product != null)
            {
                context.Remove(product);
                context.SaveChanges();
            }
        }


        public static Product? GetProduct(int id)
        {
            return context.Products.Find(id);
        }
    }
}
