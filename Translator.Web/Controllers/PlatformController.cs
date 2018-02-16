using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Translator.Web.Models;
using Translator.Web.ViewModels;

namespace Translator.Web.Controllers
{
    public class PlatformController : Controller
    {
        private readonly IPlatformRepository _platformRepository;
        public PlatformController(IPlatformRepository platformRepository)
        {
            _platformRepository = platformRepository;
        }
        public IActionResult Index()
        {
            var platforms = _platformRepository.GetAll().OrderBy(p => p.Name);
            var platformViewModel = new PlatformViewModel()
            {
                Title = "Welcome to MiTranslator",
                Platforms = platforms.ToList()
            };
            return View(platformViewModel);
        }
    }
}