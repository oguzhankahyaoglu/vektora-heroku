using System.Collections.Generic;
using System.Diagnostics;
using BayiService;
using BayiServiceTest2.Application.Repos;
using Microsoft.AspNetCore.Mvc;
using BayiServiceTest2.Models;
using Microsoft.Extensions.Caching.Memory;

namespace BayiServiceTest2.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache _cache;

        public HomeController(IMemoryCache cache)
        {
            _cache = cache;
        }

        public IActionResult Index()
        {
            var banners = new BannerRepo(_cache).GetCachedEntities().ToArray();
            ViewData["banners"] = banners;
            ViewData["categories"] = new CategoryRepo(_cache).GetCachedEntities().ToArray();
            var products = new Dictionary<string, ProductFor3rdParty[]>();
            foreach (var category in (CategoryFor3rdParty[])ViewData["categories"])
                foreach (var category2 in category.SubCategories)
                    foreach (var category3 in category2.SubCategories)
                    {
                        products.Add($"{category.CategoryID}-{category2.CategoryID}-{category3.CategoryID}", new ProductRepo(_cache).Get(false, category3.CategoryID));
                    }
            ViewData["products"] = products;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
