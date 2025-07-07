using System.Collections.Generic;
using ProductInventoryAPI_DBFirst.DTOs;

namespace ProductInventoryAPI_DBFirst.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDto> GetAll();
        ProductDto GetById(int id);
        void Add(ProductDto productDto);
        void Update(ProductDto productDto);
        void Delete(int id);
    }
}