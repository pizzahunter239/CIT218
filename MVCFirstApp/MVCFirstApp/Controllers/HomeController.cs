using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;
using System.Diagnostics;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string ID)
        {
            string seeView = ID;
            if (seeView == "CIT")
                return View("CIT218");
            else
                return View();
        }

        public IActionResult cit218()
        {
            return View();
        }

        public string myIndex()
        {
            return "Cade's Awesome Index";
        }

        public IActionResult Privacy()
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