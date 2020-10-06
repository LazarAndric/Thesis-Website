
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Http;

namespace ASP.NET_Core.Controllers
{
    public class HomeController : Controller
    {
        public static string token { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewData["msg"] = new User() { FirstName="Lazar", LastName="Andric"};
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About_Us()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Product()
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
