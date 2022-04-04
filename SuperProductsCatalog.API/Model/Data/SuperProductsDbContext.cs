using Microsoft.EntityFrameworkCore;
using SuperProductsCatalog.API.Model.Entities;

namespace SuperProductsCatalog.API.Model.Data
{
    public class SuperProductsDbContext : DbContext
    {

        public SuperProductsDbContext(DbContextOptions<SuperProductsDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }


    }
}
