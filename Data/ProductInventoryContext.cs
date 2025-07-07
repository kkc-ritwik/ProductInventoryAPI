using Microsoft.EntityFrameworkCore;
using ProductInventoryAPI_DBFirst.Models;

namespace ProductInventoryAPI_DBFirst.Data
{
    public class ProductInventoryContext : DbContext
    {
        public ProductInventoryContext(DbContextOptions<ProductInventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}