using labolatorium.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace labolatorium.Controllers
{
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Calculator(double? a, double? b, string op)
        {
            ViewBag.A = a;
            ViewBag.B = b;
            ViewBag.Op = op;

            double result = 0;
            if (a.HasValue && b.HasValue)
            {
                switch (op)
                {
                    case "add":
                        result = a.Value + b.Value;
                        break;
                    case "sub":
                        result = a.Value - b.Value;
                        break;
                    case "mul":
                        result = a.Value * b.Value;
                        break;
                    case "div":
                        if (b != 0)
                        {
                            result = a.Value / b.Value;
                        }
                        break;
                }
            }

            ViewBag.Result = result;
            return View();
        }


    }
}