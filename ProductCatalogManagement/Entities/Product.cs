using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogManagement.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Cost { get; set; }
        public bool IsInStock { get; set; }
        public string Brand { get; set; }

        public Category Category { get; set; }

        public List<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
}
