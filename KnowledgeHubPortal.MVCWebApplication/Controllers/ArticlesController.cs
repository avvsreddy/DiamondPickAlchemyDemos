using KnowledgeHubPortal.MVCWebApplication.Data;
using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System;
using System.Collections.Generic;
using Humanizer;
using Microsoft.AspNetCore.Authorization;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly KnowledgeHubDbContext db;

        // inject the db context
        public ArticlesController(KnowledgeHubDbContext db)
        {
            this.db = db;
        }

        // for on registered and login user only
        [Authorize]
        public IActionResult Create()
        {
            // return a view to collect article information
            // fetch catagory details from db

            var catagoryList = from c in db.Catagories
                               select new SelectListItem { Text = c.CatagoryName, Value = c.CatagoryID.ToString() };
            ViewBag.CatagoryList = catagoryList;
            return View();
        }
        // for on registered and login user only
        [Authorize]
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
        // only admin
        [Authorize(Roles ="admin")]
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
                                                           CatagoryName = a.Catagory.CatagoryName,
                                                           DateSubmitted = a.DateSubmited
                                                       }).ToList();
            return View(articlesToApprove);

        }
        // only admin
        [Authorize(Roles = "admin")]
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
        // only admin
        [Authorize(Roles = "admin")]
        public IActionResult ConfirmReject(List<int> articleid)
        {
            // get all articles for approval

            var articlesToReject = db.Articles.Where(a => articleid.Contains(a.ArticleID));
            db.Articles.RemoveRange(articlesToReject);
            db.SaveChanges();
            return RedirectToAction("Approve");
        }

        // anyone
        public IActionResult BrowseArticles(int catagoryId=0)
        {
            // fetch all approved articles and send to view

            List<BrowseArticleViewModel> articles = null;

            if (catagoryId == 0)
            {
                articles = (from a in db.Articles
                            where a.IsApproved
                            select new BrowseArticleViewModel
                            {
                                Title = a.Title,
                                ArticleUrl = a.ArticleUrl,
                                Description = a.Description,
                                DateSubmited = a.DateSubmited,
                                SubmittedBy = a.SubmittedBy

                            }).ToList();
            }
            else
            {
                articles = (from a in db.Articles
                            where a.IsApproved == true && a.CatagoryID == catagoryId
                            select new BrowseArticleViewModel
                            {
                                Title = a.Title,
                                ArticleUrl = a.ArticleUrl,
                                Description = a.Description,
                                DateSubmited = a.DateSubmited,
                                SubmittedBy = a.SubmittedBy

                            }).ToList();
            }

            List<SelectListItem> catagories = (from c in db.Catagories
                                               select new SelectListItem 
                                               { 
                                                   Text = c.CatagoryName, 
                                                   Value = c.CatagoryID.ToString()
                                               }).ToList();

            ViewBag.Catagories = catagories;


            return View(articles);

        }
    }
}
