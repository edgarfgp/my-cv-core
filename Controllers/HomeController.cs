using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace edgargonzalez.Controllers
{
    public class HomeController :Controller
    {

        public IActionResult Index()
        {
            ViewBag.Title = "Edgar Gonzalez";
            return View();
        }
    }
}
