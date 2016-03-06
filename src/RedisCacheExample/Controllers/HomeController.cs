using System;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;
using RedisCacheExample.Cache;

namespace RedisCacheExample.Controllers
{
    public class HomeController : Controller
    {
        protected IConfiguration Configuration;

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        
        [Cache(Duration = 30)]
        public IActionResult Index()
        {
            ViewBag.UsedCache = Convert.ToBoolean(Configuration["Cache:UseRedis"]) ? "Redis" : "In memory";
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
            return View();
        }
    }
}
