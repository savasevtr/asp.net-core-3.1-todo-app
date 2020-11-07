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
            var gorev = _gorevService.GetirAclliyetIleId(id);

            RaporAddViewModel model = new RaporAddViewModel
            {
                GorevId = id,
                Gorev = gorev
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult EkleRapor(RaporAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor
                {
                    GorevId = model.GorevId,
                    Tanim = model.Tanim,
                    Detay = model.Tanim
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult DuzenleRapor(int id)
        {
            var rapor = _raporService.GetirGorevileId(id);

            RaporEditViewModel model = new RaporEditViewModel
            {
                Id = rapor.Id,
                GorevId = rapor.GorevId,
                Gorev = rapor.Gorev,
                Tanim = rapor.Tanim,
                Detay = rapor.Detay
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult DuzenleRapor(RaporEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var rapor = _raporService.GetirIdile(model.Id);

                // rapor.GorevId = model.GorevId;
                rapor.Tanim = model.Tanim;
                rapor.Detay = model.Detay;

                _raporService.Guncelle(rapor);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult TamamlaGorev(int gorevId)
        {
            var gorev = _gorevService.GetirIdile(gorevId);
            
            gorev.Durum = true;

            _gorevService.Guncelle(gorev);

            return Json(null);
        }
    }
}