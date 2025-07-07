using System.Collections.Generic;
using ProductInventoryAPI_DBFirst.Models;

namespace ProductInventoryAPI_DBFirst.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}