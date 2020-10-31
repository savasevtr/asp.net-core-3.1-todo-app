using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;

namespace SEProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGorevService _gorevService;

        public HomeController(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}