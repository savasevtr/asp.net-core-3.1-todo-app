using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, UserManager<AppUser> userManager)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _userManager = userManager;
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

        public IActionResult GorevlendirPersonel(PersonelGorevlendirViewModel model)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == model.PersonelId);
            var gorev = _gorevService.GetirAclliyetIleId(model.GorevId);

            AppUserListViewModel appUserListViewModel = new AppUserListViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Picture = user.Picture,
                Email = user.Email
            };

            GorevListViewModel gorevListViewModel = new GorevListViewModel
            {
                Id = gorev.Id,
                Aciklama = gorev.Aciklama,
                Aciliyet = gorev.Aciliyet,
                Ad = gorev.Ad
            };

            PersonelGorevlendirListViewModel personelGorevlendirListViewModel = new PersonelGorevlendirListViewModel();
            personelGorevlendirListViewModel.AppUserListViewModel = appUserListViewModel;
            personelGorevlendirListViewModel.GorevListViewModel = gorevListViewModel;

            return View(personelGorevlendirListViewModel);
        }

        [HttpPost]
        public IActionResult GorevlendirPersonelTamamla(PersonelGorevlendirViewModel model)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenecekGorev.AppUserId = model.PersonelId;

            _gorevService.Guncelle(guncellenecekGorev);

            return RedirectToAction("Index");
        }
    }
}