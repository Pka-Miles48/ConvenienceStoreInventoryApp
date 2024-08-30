using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStoreInventoryApp
{
    static public class ProductDb
    {
        static ProductsContext context = new ProductsContext();
        public static void Add(Products product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public static List<Products> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public static void Update(Products product)
        {
            context.Update(product);
            context.SaveChanges();
        }

        public static void Delete(Products product)
        {
            context.Remove(product);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            Products product = GetProduct(id);
            if (product != null)
            {
                context.Remove(product);
                context.SaveChanges();
            }
        }


        public static Products? GetProduct(int id)
        {
            return context.Products.Find(id);
        }
    }
}
