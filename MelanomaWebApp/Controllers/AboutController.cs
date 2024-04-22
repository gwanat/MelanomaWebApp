using Microsoft.AspNetCore.Mvc;

namespace MelanomaWebApp.Controllers
{
    public class AboutController : Controller
    {
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
            return View();
        }
    }
}
