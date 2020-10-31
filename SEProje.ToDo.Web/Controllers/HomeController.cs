using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Web.Models;

namespace SEProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View(new AppUserAddViewModel());
        }

        [HttpPost]
        public IActionResult KayitOl(AppUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {

            }

            return View(model);
        }
    }
}