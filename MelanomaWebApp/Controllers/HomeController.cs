using MelanomaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MelanomaWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string currentLanguage = HttpContext.Request.Query["language"];


            if (string.IsNullOrEmpty(currentLanguage) || currentLanguage != "PL")
            {
                currentLanguage = "EN";
            } 

            ViewBag.Language = currentLanguage;

            string viewName = "Index";
            if (currentLanguage == "PL")
            {
                viewName += "_pl";
            }

            return View(viewName);
        }

        public IActionResult Index_pl()
        {
            string currentLanguage = HttpContext.Request.Query["language"];


            if (string.IsNullOrEmpty(currentLanguage) || currentLanguage != "PL")
            {
                currentLanguage = "EN";
            }

            ViewBag.Language = currentLanguage;

            string viewName = "Index";
            if (currentLanguage == "PL")
            {
                viewName += "_pl";
            }

            return View(viewName);
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
