using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStoreInventoryApp
{
    static public class ProductDb
    {
        public static void Add(Products product)
        {
            ProductsContext context = new ProductsContext();
            context.Products.Add(product);
            context.SaveChanges();
        }

        public static List<Products> GetAllProducts()
        {
            ProductsContext context = new ProductsContext();
            return context.Products.ToList();
        }

        public static void Update(Products product)
        {
            using var context = new ProductsContext();
            var existingProduct = context.Products.Find(product.ProductId);
            if (existingProduct != null)
            {
                context.Entry(existingProduct).CurrentValues.SetValues(product);
                context.SaveChanges();
            }
            else
            {
                // Handle the case where the product does not exist in the database
                throw new ArgumentException("Product not found");
            }
        }

        public static void Delete(Products product)
        {
            ProductsContext context = new ProductsContext();
            context.Remove(product);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            Products product = GetProduct(id);
            if (product != null)
            {
                ProductsContext context = new ProductsContext();
                context.Remove(product);
                context.SaveChanges();
            }
        }


        public static Products? GetProduct(int id)
        {
            ProductsContext context = new ProductsContext();
            return context.Products.Find(id);
        }
    }
}
