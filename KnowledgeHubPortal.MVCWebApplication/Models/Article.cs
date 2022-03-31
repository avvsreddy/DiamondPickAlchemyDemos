using System;
using System.ComponentModel.DataAnnotations;

namespace KnowledgeHubPortal.MVCWebApplication.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ArticleUrl { get; set; }
        public string Description { get; set; }
        public Catagory Catagory { get; set; }
        public int CatagoryID { get; set; }
        public bool IsApproved { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime DateSubmited { get; set; }
    }
}
