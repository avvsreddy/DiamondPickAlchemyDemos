using KnowledgeHubPortal.MVCWebApplication.Data;
using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class CatagoriesController : Controller
    {

        // dependancy injection
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
            //ViewBag.Catagories = catagories;
            return View(catagories);
            // List(catagories);
        }

        public IActionResult Create()
        {
            // send a view to collect catagory details from user
            return View();
        }
        public IActionResult Save(Catagory catagory)
        {
            // receive the data from view
            // validate the data
            // Rules: name is must, desc should not have more than 500 chr

            //if (string.IsNullOrEmpty(catagory.CatagoryName) || catagory.Description.Length > 500)
            if(!ModelState.IsValid)
                return View("Create");

            // send the data to model for saving in db
            db.Catagories.Add(catagory);
            db.SaveChanges();
            // send a view to list all catagories
            //List<Catagory> catagories = db.Catagories.ToList();

            //return View("List",catagory);
            return RedirectToAction("List");
        }
    }
}
