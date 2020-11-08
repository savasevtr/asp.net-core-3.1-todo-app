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
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, UserManager<AppUser> userManager, IDosyaService dosyaService, IBildirimService bildirimService)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _userManager = userManager;
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
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

            _bildirimService.Kaydet(new Bildirim
            {
                AppUserId = model.PersonelId,
                Aciklama = $"{guncellenecekGorev.Ad} adlı iş için için görevlendirildiniz."
            });

            return RedirectToAction("Index");
        }

        public IActionResult Detaylar(int id)
        {
            var gorev = _gorevService.GetirRaporlarileId(id);

            GorevListAllViewModel gorevListAllViewModel = new GorevListAllViewModel();
            gorevListAllViewModel.Id = gorev.Id;
            gorevListAllViewModel.Raporlar = gorev.Raporlar;
            gorevListAllViewModel.Ad = gorev.Ad;
            gorevListAllViewModel.Aciklama = gorev.Aciklama;
            gorevListAllViewModel.AppUser = gorev.AppUser;

            return View(gorevListAllViewModel);
        }

        public IActionResult GetirExcel(int id)
        {
            var raporlar = _gorevService.GetirRaporlarileId(id).Raporlar;

            var fileContents = _dosyaService.AktarExcel(raporlar);
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileDownloadName = Guid.NewGuid() + ".xlsx";

            return File(fileContents, contentType, fileDownloadName);
        }

        public IActionResult GetirPdf(int id)
        {
            var raporlar = _gorevService.GetirRaporlarileId(id).Raporlar;

            var virtualPath = _dosyaService.AktarPdf(raporlar);
            string fileDownloadName = Guid.NewGuid() + ".pdf";
            string contentType = "application/pdf";

            return File(virtualPath, contentType, fileDownloadName);
        }
    }
}