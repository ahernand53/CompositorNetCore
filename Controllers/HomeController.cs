using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ytWebGentile.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        [ViewData]
        public string CustomProperty { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            ViewData["property1"] = "Asdrubal Hernandez";
            CustomProperty = "Custom value";
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
