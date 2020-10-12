
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Http;
using ASP.NET_Core.APIComunication;
using System.Net.Http;
using Nancy.Json;
using System.Collections.Generic;

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
            var jsonString = APIClient.SetAPIClient("Product/", APIClient.Token, HttpMethod.Get);
            
            ViewBag.Shop = jsonString;
            return View();
        }
        [HttpPost]
        public IActionResult Shop(FiltersSearchDto filters)
        {
            var jsonString = APIClient.SetAPIClient<FiltersSearchDto>("Shop/Filtrate", filters, APIClient.Token, HttpMethod.Get);
            if (jsonString == null)
                return ViewBag.Shop = string.Empty;
            ViewBag.Shop = jsonString;
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
