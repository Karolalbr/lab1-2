using System;
using Microsoft.AspNetCore.Mvc;

namespace labolatorium.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Birth model)
        {
            if (ModelState.IsValid)
            {
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - model.BirthDate.Year;
                ViewBag.Message = $"Cześć {model.Name}, masz {age} lat(a).";
                return View("Result");
            }
            return View("Form", model);
        }
    }
}
