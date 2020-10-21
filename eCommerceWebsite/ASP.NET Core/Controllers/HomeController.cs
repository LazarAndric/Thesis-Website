
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
        public static FiltersSearchDto filter;
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

        public IActionResult About_Us()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewPage()
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var jsonString = HttpContext.Session.GetString("products");
            var itemsProduct = jsonSerializer.Deserialize<List<ProductReadDto>>(jsonString);
            var maxItem = 9 * filter.PageNumber;
            var minItem = maxItem - 9;

            //TESTIRATI
            foreach (var item in itemsProduct)
                item.CategoryId = item.Category.Id;
            var response = APIClient.SetAPIClient<List<ProductReadDto>>("Shop/Paging/" + minItem + "/" + maxItem, itemsProduct, HttpMethod.Get);
            ViewBag.ShopView = response;
            HttpContext.Session.SetString("productPaging", response);
            return View("Shop", filter);
        }
        public IActionResult Shop()
        {
            filter = new FiltersSearchDto();
            var jsonString = APIClient.SetAPIClient<FiltersSearchDto>("Shop/Filtrate", filter, APIClient.Token, HttpMethod.Get);
            filter = InitializeFilter();
            HttpContext.Session.SetString("products", jsonString);
            //BITNO
            ViewBag.Shop = jsonString;
            return NewPage();
        }
        public FiltersSearchDto InitializeFilter()
        {
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
            return filter;
        }

        [HttpPost]
        public IActionResult Shop(FiltersSearchDto filters)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            filter = filters;
            var items = jsonSerializer.Serialize(filters);
            var jsonString = APIClient.SetAPIClient<FiltersSearchDto>("Shop/Filtrate", filters, APIClient.Token, HttpMethod.Get);
            HttpContext.Session.SetString("products", jsonString);
            ViewBag.Shop = jsonString;
            return NewPage();
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
        public IActionResult PagingView(FiltersSearchDto filterSearch)
        {
            filter.PageNumber = filterSearch.PageNumber;
            var jsonString=HttpContext.Session.GetString("products");
            ViewBag.Shop = jsonString;
            return NewPage();
        }
        public IActionResult Product(FiltersSearchDto filter)
        {
            var productId = filter.ProductForViewId;
            var jsonString = APIClient.SetAPIClient("Product/GetProductById/", data: productId.ToString(), APIClient.Token, HttpMethod.Get);
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            var product = jsonSerializer.Deserialize<ProductReadDto>(jsonString);
            APIClient.SetAPIClient("Product/ViewsCounts/", data: product.Id.ToString(), APIClient.Token, HttpMethod.Get);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
