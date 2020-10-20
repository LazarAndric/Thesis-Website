
using ASP.NET_Core.APIComunication;
using ASP.NET_Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nancy.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;

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

            ViewData["msg"] = new User() { FirstName = "Lazar", LastName = "Andric" };
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
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var filters = HttpContext.Session.GetString("productsPage1");
            var itemsFilter = jsonSerializer.Deserialize<FiltersSearchDto>(filters);
            itemsFilter.PageNumber = pagingFilter.PageNumber;

            var jsonString = HttpContext.Session.GetString("products");
            var itemsProduct = jsonSerializer.Deserialize<List<Product>>(jsonString);
            var maxItem = 9 * pagingFilter.PageNumber;
            var minItem = maxItem - 9;
            foreach (var item in itemsProduct)
                item.CategoryId = item.Category.Id;
            var response = APIClient.SetAPIClient<List<Product>>("Shop/Paging/" + minItem + "/" + maxItem, itemsProduct, HttpMethod.Get);
            ViewBag.ShopPaging = response;
            HttpContext.Session.SetString("productsPage", response);
            return View("Shop", itemsFilter);
        }



        public IActionResult Shop()
        {
            var filter = InitializeFilter();
            var jsonString = APIClient.SetAPIClient("Product/", APIClient.Token, HttpMethod.Get);
            ViewBag.Shop = jsonString;
            HttpContext.Session.SetString("products", jsonString);
            return NewPage(filter);
        }
        public FiltersSearchDto InitializeFilter()
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
            

            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var items = jsonSerializer.Serialize(filter);
            HttpContext.Session.SetString("productsPage1", items);

            return filter;
        }

        [HttpPost]
        public IActionResult Shop(FiltersSearchDto filters)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var items = jsonSerializer.Serialize(filters);
            HttpContext.Session.SetString("productsPage1", items);

            var jsonString = APIClient.SetAPIClient<FiltersSearchDto>("Shop/Filtrate", filters, APIClient.Token, HttpMethod.Get);
            HttpContext.Session.SetString("products", jsonString);

            return NewPage(filters);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PreviewProduct(FiltersSearchDto filter)
        {
            return View();
        }
        public IActionResult Product(FiltersSearchDto filter)
        {
            var productId = filter.ProductForViewId;
            var jsonString = APIClient.SetAPIClient("Product/GetProductById/", data: productId.ToString(), APIClient.Token, HttpMethod.Get);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var product = jsonSerializer.Deserialize<Product>(jsonString);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Order()
        {
            return View();
        }
    }
}
