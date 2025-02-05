using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission_5_Assignment.Models;

namespace Mission_5_Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Hobby()
        {
            ViewData["Title"] = "Hobby";
            return View();
        }

        public IActionResult Calculator()
        {
            ViewData["Title"] = "Calculator";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
