using System.ComponentModel.DataAnnotations;

namespace SuperProductsCatalog.API.Model.Entities
{

    // Domain Class - Entity 
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public string Brand { get; set; }
    }
}
