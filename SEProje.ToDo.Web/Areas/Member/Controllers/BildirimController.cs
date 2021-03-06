﻿using System.Collections.Generic;
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

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
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

            var model = _mapper.Map<List<BildirimListDto>>(_bildirimService.GetirOkunmayanlar(user.Id));

            return View(model);
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