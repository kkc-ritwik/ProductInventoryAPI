using System.Collections.Generic;
using System.Linq;
using ProductInventoryAPI_DBFirst.DTOs;
using ProductInventoryAPI_DBFirst.Models;
using ProductInventoryAPI_DBFirst.Repositories;

namespace ProductInventoryAPI_DBFirst.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _repo.GetAll().Select(p => new ProductDto
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Quantity = p.Quantity,
                Price = p.Price
            });
        }

        public ProductDto GetById(int id)
        {
            var p = _repo.GetById(id);
            if (p == null) return null;

            return new ProductDto
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Quantity = p.Quantity,
                Price = p.Price
            };
        }

        public void Add(ProductDto dto)
        {
            var p = new Product
            {
                Name = dto.Name,
                Quantity = dto.Quantity,
                Price = dto.Price
            };
            _repo.Add(p);
        }

        public void Update(ProductDto dto)
        {
            var p = new Product
            {
                ProductId = dto.ProductId,
                Name = dto.Name,
                Quantity = dto.Quantity,
                Price = dto.Price
            };
            _repo.Update(p);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}