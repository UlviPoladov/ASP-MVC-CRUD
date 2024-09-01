using WebApplication8.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApplication8.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) 
        : base(options) { }
        
        public DbSet<Product> Products { get; set; }
        
    }
}
