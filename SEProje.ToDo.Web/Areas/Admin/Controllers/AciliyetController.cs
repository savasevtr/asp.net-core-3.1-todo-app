﻿using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DTO.DTOs.AciliyetDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.StringInfo;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class AciliyetController : Controller
    {
        private readonly IAciliyetService _aciliyetService;
        private readonly IMapper _mapper;

        public AciliyetController(IAciliyetService aciliyetService, IMapper mapper)
        {
            _aciliyetService = aciliyetService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = _mapper.Map<List<AciliyetListDto>>(_aciliyetService.GetirHepsi());

            return View(model);
        }

        public IActionResult AciliyetEkle()
        {
            return View(new AciliyetAddDto());
        }

        [HttpPost]
        public IActionResult AciliyetEkle(AciliyetAddDto model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Kaydet(new Aciliyet()
                {
                    Tanim = model.Tanim
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult AciliyetDuzenle(int id)
        {
            //var aciliyet = _aciliyetService.GetirIdile(id);

            //AciliyetEditViewModel model = new AciliyetEditViewModel
            //{
            //    Id = aciliyet.Id,
            //    Tanim = aciliyet.Tanim
            //};

            var model = _mapper.Map<AciliyetUpdateDto>(_aciliyetService.GetirIdile(id));

            return View(model);
        }

        [HttpPost]
        public IActionResult AciliyetDuzenle(AciliyetUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Guncelle(new Aciliyet
                {
                    Id = model.Id,
                    Tanim = model.Tanim
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}