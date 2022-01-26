using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DateMe.Models;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DateApplicationContext blahContext { get; set; }

        // Constructor 
        public HomeController(ILogger<HomeController> logger, DateApplicationContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DatingApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DatingApplication (ApplicationResponse ar)
        {
            //Connet to database also
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirmation", ar);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
