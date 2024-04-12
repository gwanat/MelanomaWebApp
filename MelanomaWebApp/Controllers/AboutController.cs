using Microsoft.AspNetCore.Mvc;

namespace MelanomaWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index_pl()
        {
            return View();
        }
    }
}
