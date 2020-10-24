using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Web.Models;

namespace SEProje.ToDo.Web.Controllers
{
    // [Route("kisiler/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.isim = "Savaş";
            TempData["isim"] = "Ramo";
            ViewData["isim"] = "Deli Veli";

            return View(new List<MusteriViewModel>
            {
                new MusteriViewModel() { Ad = "Ali" },
                new MusteriViewModel() { Ad = "Ramo" },
                new MusteriViewModel() { Ad = "Cemo" },
                new MusteriViewModel() { Ad = "Memo" },
                new MusteriViewModel() { Ad = "Ayşo" },
            });
        }

        public IActionResult Sonuc()
        {
            return View();
        }
    }
}
