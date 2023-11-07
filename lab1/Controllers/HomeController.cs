using lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lab1.Controllers
{
    public enum Operators
    {
        add, sub, mul, div
    }
    public class HomeController : Controller
    {
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
        public IActionResult About(string author, int? id)
        {
            ViewBag.Author = author + " " + id;

            return View();
        }
        public IActionResult Calculator(string? op, double? a, double? b)
        {
            if (a == null || b == null)
            {
                ViewBag.Error = "Podaj wartości dla a i b.";
                return View();
            }
            double? result = 0;
            switch (op)
            {
                case "add":
                    result = a + b;
                    ViewBag.Op = "+";
                    break;
                case "sub":
                    result = a - b;
                    ViewBag.Op = "-";
                    break;
                case "mul":
                    result = a * b;
                    ViewBag.Op = "*";
                    break;
                case "div":
                    result = a / b;
                    ViewBag.Op = "/";
                    break;
            }
            ViewBag.Result = result;
            ViewBag.a = a; ViewBag.b = b;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}