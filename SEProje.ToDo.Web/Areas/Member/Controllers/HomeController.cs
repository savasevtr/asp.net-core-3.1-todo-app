using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.BaseControllers;
using SEProje.ToDo.Web.StringInfo;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class HomeController : BaseIdentityController
    {
        private readonly IRaporService _raporService;
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;

        public HomeController(UserManager<AppUser> userManager, IRaporService raporService, IGorevService gorevService, IBildirimService bildirimService) : base(userManager)
        {
            _raporService = raporService;
            _gorevService = gorevService;
            _bildirimService = bildirimService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await GetirGirisYapanKullanici();

            ViewBag.raporSayisi = _raporService.GetirRaporSayisiileAppUserId(user.Id);
            ViewBag.tamamlananGorevSayisi = _gorevService.GetirGorevSayisiTamamlananileAppUserId(user.Id);
            ViewBag.okunmayanBildirimSayisi = _bildirimService.GetirOkunmayanSayisiileAppUserId(user.Id);
            ViewBag.tamamlanmayanGorevSayisi = _gorevService.GetirGorevSayisiTamamlanmayanileAppUserId(user.Id);

            return View();
        }
    }
}