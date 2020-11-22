using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;
using SEProje.ToDo.DTO.DTOs.RaporDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.BaseControllers;
using SEProje.ToDo.Web.StringInfo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public IsEmriController(
            IAppUserService appUserService,
            IGorevService gorevService,
            UserManager<AppUser> userManager,
            IDosyaService dosyaService,
            IBildirimService bildirimService,
            IMapper mapper
        ) : base(userManager) {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var models = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla());

            return View(models);
        }

        public IActionResult PersonelAta(int id, string search, int page = 1)
        {
            ViewBag.currentPage = page;
            ViewBag.search = search;

            var personeller = _mapper.Map<List<AppUserListDto>>(_appUserService.GetirAdminOlmayanlar(out int pageCount, search, page));

            ViewBag.pageCount = pageCount;

            ViewBag.Personeller = personeller;

            var model = _mapper.Map<GorevListDto>(_gorevService.GetirAclliyetIleId(id));

            return View(model);
        }

        public IActionResult GorevlendirPersonel(PersonelGorevlendirDto model)
        {
            var userListDto = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(x => x.Id == model.PersonelId));

            var gorevListDto = _mapper.Map<GorevListDto>(_gorevService.GetirAclliyetIleId(model.GorevId));

            PersonelGorevlendirListDto personelGorevlendirListDto = new PersonelGorevlendirListDto
            {
                AppUser = userListDto,
                Gorev = gorevListDto
            };

            return View(personelGorevlendirListDto);
        }

        [HttpPost]
        public IActionResult GorevlendirPersonelTamamla(PersonelGorevlendirDto model)
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
            return View(_mapper.Map<GorevListAllDto>(_gorevService.GetirRaporlarileId(id)));
        }

        public IActionResult GetirExcel(int id)
        {
            var raporlar = _mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(id).Raporlar);

            var fileContents = _dosyaService.AktarExcel(raporlar);
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            string fileDownloadName = Guid.NewGuid() + ".xlsx";

            return File(fileContents, contentType, fileDownloadName);
        }

        public IActionResult GetirPdf(int id)
        {
            var raporlar = _mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(id).Raporlar);

            var virtualPath = _dosyaService.AktarPdf(raporlar);
            string fileDownloadName = Guid.NewGuid() + ".pdf";
            string contentType = "application/pdf";

            return File(virtualPath, contentType, fileDownloadName);
        }
    }
}