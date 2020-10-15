
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
        public static int brojac=0;
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
        public IActionResult NewPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewPage(FiltersSearchDto pagingFilter)
        {
            var jsonString = HttpContext.Session.GetString("products");
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var items = jsonSerializer.Deserialize<List<Product>>(jsonString);
            var maxItem = 9 * pagingFilter.pageNumber;
            var minItem = maxItem - 9;
            foreach (var item in items)
                item.CategoryId = item.Category.Id;
            var response = APIClient.SetAPIClient<List<Product>>("Shop/Paging/" + minItem + "/" + maxItem, items, HttpMethod.Get);
            ViewBag.Shop = response;
            HttpContext.Session.SetString("products", response);
            return Redirect( "Shop");
        }
        //[HttpPost]
        //public IActionResult PriceFilterController(FilterForPriceSearchDto priceFilter)
        //{
        //    filter.PriceFilter = priceFilter;
        //    return View();
        //}
        public IActionResult Shop()
        {
            FiltersSearchDto filter = new FiltersSearchDto();
            FilterForPriceSearchDto priceFilter = new FilterForPriceSearchDto();
            FilterForCategorySearchDto categoryFilter = new FilterForCategorySearchDto();
            FilterForGenderSearchDto genderFilter = new FilterForGenderSearchDto();
            FilterForSizeSearchDto sizeFilter = new FilterForSizeSearchDto();
            Sort sort = new Sort();
            filter.PriceFilter = priceFilter;
            filter.CategoryFilter = categoryFilter;
            filter.SizeFilter = sizeFilter;
            filter.SortItems = sort;
            filter.GenderFilter = genderFilter;
            if (brojac == 0)
            {
                
                var jsonString = APIClient.SetAPIClient("Product/", APIClient.Token, HttpMethod.Get);
                ViewBag.Shop = jsonString;
                HttpContext.Session.SetString("products", jsonString);
                brojac++;
                
            }
            ViewBag.Shop=HttpContext.Session.GetString("products");
            return View(filter);

        }
        [HttpPost]
        public IActionResult Shop(FiltersSearchDto filters)
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
