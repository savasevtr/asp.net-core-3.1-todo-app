using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;

        public GorevController(IGorevService gorevService, UserManager<AppUser> userManager)
        {
            _gorevService = gorevService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            int pageCount;

            var gorevler = _gorevService.GetirTumTablolarlaTamamlanan(out pageCount, user.Id, page);

            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();

            foreach (var gorev in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel
                {
                    Id = gorev.Id,
                    Ad = gorev.Ad,
                    Aciklama = gorev.Aciklama,
                    Aciliyet = gorev.Aciliyet,
                    
                    AppUser = gorev.AppUser,
                    OlusturmaTarihi = gorev.OlusturmaTarihi,
                    Raporlar = gorev.Raporlar
                };

                models.Add(model);
            }

            ViewBag.pageCount = pageCount;
            ViewBag.currentPage = page;

            return View(models);
        }
    }
}
