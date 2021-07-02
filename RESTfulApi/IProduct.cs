using RESTfulApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfulApi
{
    public interface IProduct
    {
        IEnumerable<Product> Get();
        IEnumerable<Product> SortByPrice();
        IEnumerable<Product> SortByType();
        Product Get(int id);
        void Create(Product item);
        void Update(Product item);
        Product Delete(int id);

    }
}
