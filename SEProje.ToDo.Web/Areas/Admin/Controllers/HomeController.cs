using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IRaporService _raporService;

        public HomeController(IGorevService gorevService, IBildirimService bildirimService, UserManager<AppUser> userManager, IRaporService raporService)
        {
            _gorevService = gorevService;
            _bildirimService = bildirimService;
            _userManager = userManager;
            _raporService = raporService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.atanmayiBekleyenGorevSayisi = _gorevService.GetirGorevSayisiAtanmayiBekleyen();
            ViewBag.tamamlananGorevSayisi = _gorevService.GetirGorevSayisiTamamlanan();
            ViewBag.okunmayanBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);
            ViewBag.raporSayisi = _raporService.GetirRaporSayisi();

            return View();
        }
    }
}