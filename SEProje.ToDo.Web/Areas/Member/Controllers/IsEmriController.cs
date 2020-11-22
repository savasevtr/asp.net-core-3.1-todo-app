using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;
using SEProje.ToDo.DTO.DTOs.RaporDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.BaseControllers;
using SEProje.ToDo.Web.StringInfo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;
        private readonly IRaporService _raporService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public IsEmriController(UserManager<AppUser> userManager, IGorevService gorevService, IRaporService raporService, IBildirimService bildirimService, IMapper mapper) : base(userManager)
        {
            _gorevService = gorevService;
            _raporService = raporService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var user = await GetirGirisYapanKullanici();

            var model = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla(x => x.AppUserId == user.Id && !x.Durum));

            return View(model);
        }

        public IActionResult EkleRapor(int id)
        {
            var gorev = _gorevService.GetirAclliyetIleId(id);

            RaporAddDto model = new RaporAddDto
            {
                GorevId = id,
                Gorev = gorev
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EkleRapor(RaporAddDto model)
        {
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor
                {
                    GorevId = model.GorevId,
                    Tanim = model.Tanim,
                    Detay = model.Tanim
                });

                var adminUsers = await _userManager.GetUsersInRoleAsync("Admin");
                var currentUser = await GetirGirisYapanKullanici();

                foreach (var item in adminUsers)
                {
                    _bildirimService.Kaydet(new Bildirim
                    {
                        Aciklama = $"{currentUser.Name} {currentUser.Surname} yeni bir rapor yazdı.",
                        AppUserId = item.Id
                    });
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult DuzenleRapor(int id)
        {
            var model = _mapper.Map<RaporUpdateDto>(_raporService.GetirGorevileId(id));

            return View(model);
        }

        [HttpPost]
        public IActionResult DuzenleRapor(RaporUpdateDto model)
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

        public async Task<IActionResult> TamamlaGorev(int gorevId)
        {
            var gorev = _gorevService.GetirIdile(gorevId);
            
            gorev.Durum = true;

            _gorevService.Guncelle(gorev);

            var adminUsers = await _userManager.GetUsersInRoleAsync("Admin");
            var currentUser = await GetirGirisYapanKullanici();

            foreach (var item in adminUsers)
            {
                _bildirimService.Kaydet(new Bildirim
                {
                    Aciklama = $"{currentUser.Name} {currentUser.Surname} vermiş olduğunuz bir görevi tamamladı.",
                    AppUserId = item.Id
                });
            }

            return Json(null);
        }
    }
}