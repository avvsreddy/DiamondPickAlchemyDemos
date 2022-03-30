using System.ComponentModel.DataAnnotations;

namespace KnowledgeHubPortal.MVCWebApplication.Models
{
    // Entity Class - Domain Class
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required (ErrorMessage ="Kindly enter the catagory name")]
        public string CatagoryName { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        //[RegularExpression("")]
        //[Range(10,10000)]
        //[EmailAddress]

    }
}
