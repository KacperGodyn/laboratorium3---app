using Microsoft.AspNetCore.Mvc;
using lab2.Models;
using System;

namespace lab2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Greet(Birth model)
        {
            if (model == null)
            {
                // Możesz dodać logikę lub zwrócić widok błędu
                return View("Error");
            }

            if (model.IsValid())
            {
                return View(model);
            }
            else
            {
                return View("Error");
            }
        }


    }
}
