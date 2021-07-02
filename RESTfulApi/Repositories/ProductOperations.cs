using Microsoft.EntityFrameworkCore;
using RESTfulApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulApi.Repositories
{
    public class ProductOperations : IProduct
    {
        private DataContext Context;
        public ProductOperations(DataContext context)
        {
            Context = context;
        }
        public IEnumerable<Product> Get()
        {
            return Context.Products;
        }
        public IEnumerable<Product> SortByPrice()
        {
            return Context.Products.OrderBy(c => c.Price);
        }
        public IEnumerable<Product> SortByType()
        {
            return Context.Products.OrderBy(c => c.ProductType);
        }
        public Product Get(int Id)
        {
            return Context.Products.AsNoTracking().Where(c => c.Id == Id).Select(c => c).FirstOrDefault();
        }
        public void Create(Product item)
        {
            Context.Products.Add(item);
            Context.SaveChanges();
        }
        public void Update(Product item)
        {
            Product item2 = Get(item.Id);

            if (item2 != null)
            {
                Context.Products.Update(item);
                Context.SaveChanges();
            }
        }

        public Product Delete(int Id)
        {
            Product item = Get(Id);

            if (item != null)
            {
                Context.Products.Remove(item);
                Context.SaveChanges();
            }

            return item;
        }
    }
}
