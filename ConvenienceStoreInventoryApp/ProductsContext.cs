using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenienceStoreInventoryApp
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = Desired name for Database
            // Server = Server we are connecting to. LocalDB is included in with VsCode
            // Truested_Connection _ indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ConvenienceStoreInventoryDb;Trusted_Connection=True;");
        }
    }
}
