using APICatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalog.Context
{
    public class APICatalogDbContext : DbContext
    {
        public APICatalogDbContext(DbContextOptions<APICatalogDbContext> options) : base(options)
        {}
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

    }
}