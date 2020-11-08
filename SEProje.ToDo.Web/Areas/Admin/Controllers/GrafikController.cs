using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SEProje.ToDo.Business.Interfaces;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class GrafikController : Controller
    {
        private readonly IAppUserService _appUserService;

        public GrafikController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnCokGorevTamamlayan()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevTamamlamisPersoneller());

            return Json(jsonString);
        }

        public IActionResult EnCokGorevdeCalisan()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetirEnCokGorevdeCalisanPersoneller());

            return Json(jsonString);
        }
    }
}
