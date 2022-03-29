using KnowledgeHubPortal.MVCWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeHubPortal.MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // /home/index
        public IActionResult Index()
        {
            return View();
        }
        // /home/privacy
        public IActionResult Privacy()
        {
            return View();
        }


        // /home/error
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // home/about
        public IActionResult about()
        {
            return View();
        }
    }
}
