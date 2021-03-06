using KnowledgeHubPortal.MVCWebApplication.Data;
using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    [Authorize(Roles ="admin")]
    public class CatagoriesController : Controller
    {

        // dependancy injection
        private readonly KnowledgeHubDbContext db;

        public CatagoriesController(KnowledgeHubDbContext db)
        {
            this.db = db;
        }


        // /Catagories/List
        [AllowAnonymous]
        public async Task<IActionResult> List(string searchTerm)
        {
            // get all catagories from db
            List<Catagory> catagories = null;
            if (string.IsNullOrWhiteSpace(searchTerm))
                catagories = await db.Catagories.ToListAsync();
            else
                catagories = await (from c in db.Catagories
                              where c.CatagoryName.Contains(searchTerm) || c.Description.Contains(searchTerm)
                              select c).ToListAsync(); //LINQ

                                // LINQPAd

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
        public async Task<IActionResult> Save(Catagory catagory)
        {
            // receive the data from view
            // validate the data
            // Rules: name is must, desc should not have more than 500 chr

            //if (string.IsNullOrEmpty(catagory.CatagoryName) || catagory.Description.Length > 500)
            if(!ModelState.IsValid)
                return View("Create");

            // send the data to model for saving in db
            db.Catagories.Add(catagory);
            await db.SaveChangesAsync();
            // send a view to list all catagories
            //List<Catagory> catagories = db.Catagories.ToList();

            //return View("List",catagory);
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Delete(int id)
        {
            // get the remaining info from db
            Catagory catagoryToDelete = await db.Catagories.FindAsync(id);
            return View(catagoryToDelete);
            //db.Catagories.Remove(catagoryToDelete);
            //db.SaveChanges();

            //return View();
        }
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            Catagory catagoryToDelete = db.Catagories.Find(id);
            db.Catagories.Remove(catagoryToDelete);
            await db.SaveChangesAsync();

            TempData["Message"] = $"{catagoryToDelete.CatagoryName} is successfully deleted";
            return RedirectToAction("List");
        }
        public async Task<IActionResult> Edit(int id)
        {
            // get the remaining catagory info from db
            var catagoryToEdit = await db.Catagories.FindAsync(id);
            // return a view to edit the data
            return View(catagoryToEdit);

        }
        public async Task<IActionResult> Update(Catagory catagoryToUpdate)
        {
            if (!ModelState.IsValid)
                return View("Edit", catagoryToUpdate);

            // send the data to model for updating in db
            db.Entry(catagoryToUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await db.SaveChangesAsync();
            // send a view to list all catagories
            //List<Catagory> catagories = db.Catagories.ToList();
            TempData["Message"] = $"{catagoryToUpdate.CatagoryName} is successfully updated";
            //return View("List",catagory);
            return RedirectToAction("List");
        }
    }
}
