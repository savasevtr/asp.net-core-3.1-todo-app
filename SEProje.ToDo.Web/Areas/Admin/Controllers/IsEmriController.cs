using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;

        public IsEmriController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            var model = _appUserService.GetirAdminOlmayanlar();

            return View(model);
        }
    }
}