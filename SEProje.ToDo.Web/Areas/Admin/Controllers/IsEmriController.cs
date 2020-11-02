using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;
using System;
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

        public IActionResult PersonelAta(int id, string search, int page = 1)
        {
            ViewBag.currentPage = page;
            ViewBag.search = search;
            // ViewBag.pageCount = (int)Math.Ceiling((double)_appUserService.GetirAdminOlmayanlar().Count / 3);

            int pageCount;

            var gorev = _gorevService.GetirAclliyetIleId(id);
            var personeller = _appUserService.GetirAdminOlmayanlar(out pageCount, search, page);
            ViewBag.pageCount = pageCount;

            List<AppUserListViewModel> appUserListViewModels = new List<AppUserListViewModel>();

            foreach (var item in personeller)
            {
                AppUserListViewModel appUserListViewModel = new AppUserListViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Surname = item.Surname,
                    Email = item.Email,
                    Picture = item.Picture
                };

                appUserListViewModels.Add(appUserListViewModel);
            }

            ViewBag.Personeller = appUserListViewModels;

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