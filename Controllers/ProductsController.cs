using Microsoft.AspNetCore.Mvc;
using ProductInventoryAPI_DBFirst.DTOs;
using ProductInventoryAPI_DBFirst.Services;
using System.Collections.Generic;

namespace ProductInventoryAPI_DBFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetById(int id)
        {
            var product = _service.GetById(id);
            if (product == null) return NotFound();
            return product;
        }

        [HttpPost]
        public IActionResult Create(ProductDto dto)
        {
            _service.Add(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.ProductId }, dto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductDto dto)
        {
            if (id != dto.ProductId) return BadRequest();
            _service.Update(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}