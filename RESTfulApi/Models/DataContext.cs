using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulApi.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            //Products.Add(new Product { Id = 1, Name = "black t-shirt", Price = 1000, ProductType = "Clothes", SKU = "TSHIRT_BLACK" });
            //Products.Add(new Product { Id = 2, Name = "red t-shirt", Price = 1100, ProductType = "Clothes", SKU = "TSHIRT_RED" });
            //Products.Add(new Product { Id = 3, Name = "green t-shirt", Price = 1200, ProductType = "Clothes", SKU = "TSHIRT_GREEN" });
        }
    }
}
