using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A1U2.Models;
using Microsoft.AspNetCore.Mvc;


namespace A1U2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Resultado(Numeros n)
        {
            return View(n);
        }
    }
}
