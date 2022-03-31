using KnowledgeHubPortal.MVCWebApplication.Data;
using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using System.Collections.Generic;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext db;

        // inject the db context
        public ArticlesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            // return a view to collect article information
            // fetch catagory details from db

            var catagoryList = from c in db.Catagories
                               select new SelectListItem { Text = c.CatagoryName, Value = c.CatagoryID.ToString() };
            ViewBag.CatagoryList = catagoryList;
            return View();
        }

        public IActionResult Save(Article article)
        {
            // do validation
            if (!ModelState.IsValid)
                return RedirectToAction("Create");

            // fill other data

            article.DateSubmited = DateTime.Now;
            article.IsApproved = false;
            article.SubmittedBy = User.Identity.Name;

            // save data
            db.Articles.Add(article);
            db.SaveChanges();
            TempData["Message"] = $"{article.Title} has been created successfully";
            return RedirectToAction("Create");

        }
        public IActionResult Approve()
        {
            // fetch the data required for approve view and return

            List<ArticleViewModel> articlesToApprove = (from a in db.Articles
                                                       where a.IsApproved == false
                                                       select new ArticleViewModel
                                                       {
                                                           ArticleID = a.ArticleID,
                                                           Title = a.Title,
                                                           ArticleUrl = a.ArticleUrl,
                                                           CatagoryName = a.Catagory.CatagoryName
                                                       }).ToList();
            return View(articlesToApprove);

        }

        public IActionResult ConfirmApproval(List<int> articleid)
        {
            // get all articles for approval

            var articlesToApprove = db.Articles.Where(a => articleid.Contains(a.ArticleID));
            foreach (var a in articlesToApprove)
            {
                a.IsApproved = true;
            }
            db.SaveChanges();
            return RedirectToAction("Approve");
        }

        public IActionResult ConfirmReject(List<int> articleid)
        {
            // get all articles for approval

            var articlesToReject = db.Articles.Where(a => articleid.Contains(a.ArticleID));
            db.Articles.RemoveRange(articlesToReject);
            db.SaveChanges();
            return RedirectToAction("Approve");
        }
    }
}
