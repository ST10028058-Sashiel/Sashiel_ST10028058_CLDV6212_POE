using Microsoft.AspNetCore.Mvc;
using Sashiel_ST10028058_CLDV6212_POE.Models;
using System.Diagnostics;

namespace Sashiel_ST10028058_CLDV6212_POE.Controllers
{
    public class HomeController : Controller
    {
        //Home an About Us Controller

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
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
