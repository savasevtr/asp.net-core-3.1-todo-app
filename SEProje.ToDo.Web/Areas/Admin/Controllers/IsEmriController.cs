using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;
using System.Collections.Generic;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
        }

        public IActionResult Index()
        {
            // var model = _appUserService.GetirAdminOlmayanlar();
            List<Gorev> gorevler = _gorevService.GetirTumTablolarla();
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
                    OlusturmaTarihi = item.OlusturmaTarihi,
                    Raporlar = item.Raporlar
                };

                models.Add(model);
            }

            return View(models);
        }

        public IActionResult PersonelAta(int id)
        {
            var gorev = _gorevService.GetirAclliyetIleId(id);

            GorevListViewModel model = new GorevListViewModel()
            {
                Id = gorev.Id,
                Ad = gorev.Ad,
                Aciklama = gorev.Aciklama,
                Aciliyet = gorev.Aciliyet,
                OlusturmaTarihi = gorev.OlusturmaTarihi,
            };

            return View(model);
        }
    }
}