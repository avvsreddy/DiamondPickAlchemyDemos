using Microsoft.EntityFrameworkCore;
using ProductCatalogManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogManagement.DataAccess
{
    public class ProductsCatalogDbContext : DbContext
    {
        public ProductsCatalogDbContext()
        {

        }
        public ProductsCatalogDbContext(DbContextOptions<ProductsCatalogDbContext> options):base(options)
        {
            // this ctor will be used by mvc/web api applications
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // this will be used by non web application
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=MyProductsCatalogDb;Integrated Security=True");
                
                optionsBuilder.LogTo ( Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            }
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
