using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;
using SEProje.ToDo.Web.Areas.Member.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class IsEmriController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IGorevService _gorevService;
        private readonly IRaporService _raporService;

        public IsEmriController(UserManager<AppUser> userManager, IGorevService gorevService, IRaporService raporService)
        {
            _userManager = userManager;
            _gorevService = gorevService;
            _raporService = raporService;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var gorevler = _gorevService.GetirTumTablolarla(x => x.AppUserId == user.Id && !x.Durum);

            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();

            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel
                {
                    Id = item.Id,
                    Aciklama = item.Aciklama,
                    Aciliyet = item.Aciliyet,
                    Ad = item.Ad,
                    AppUser = item.AppUser,
                    Raporlar = item.Raporlar,
                    OlusturmaTarihi = item.OlusturmaTarihi,
                };

                models.Add(model);
            }

            return View(models);
        }

        public IActionResult EkleRapor(int id)
        {
            RaporAddViewModel model = new RaporAddViewModel
            {
                GorevId = id
            };

            return View(model);
        }

        public IActionResult DuzenleRapor(int id)
        {
            return View();
        }
    }
}