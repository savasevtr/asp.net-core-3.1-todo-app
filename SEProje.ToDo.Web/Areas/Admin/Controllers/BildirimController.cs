using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DTO.DTOs.BildirimDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.BaseControllers;
using SEProje.ToDo.Web.StringInfo;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class BildirimController : BaseIdentityController
    {
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public BildirimController(IBildirimService bildirimService, UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _bildirimService = bildirimService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var user = await GetirGirisYapanKullanici();

            var models = _mapper.Map<List<BildirimListDto>>(_bildirimService.GetirOkunmayanlar(user.Id));

            return View(models);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var bildirim = _bildirimService.GetirIdile(id);
            bildirim.Durum = true;
            _bildirimService.Guncelle(bildirim);

            return RedirectToAction("Index");
        }
    }
}