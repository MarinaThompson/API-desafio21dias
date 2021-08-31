using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_razor.Helpers;


namespace mvc_razor.Controllers
{
    [Logado]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
