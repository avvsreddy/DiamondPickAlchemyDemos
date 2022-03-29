using KnowledgeHubPortal.MVCWebApplication.Data;
using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class CatagoriesController : Controller
    {
        private readonly ApplicationDbContext db;

        public CatagoriesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // /Catagories/List
        public IActionResult List()
        {
            // get all catagories from db
            List<Catagory> catagories =  db.Catagories.ToList();
            // pass catagories to view and display
            // create view

            return View();
        }
    }
}
