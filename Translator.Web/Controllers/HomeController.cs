using Microsoft.AspNetCore.Mvc;

namespace Translator.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Welcome to MiTranslator";
            return View();
        }
    }
}