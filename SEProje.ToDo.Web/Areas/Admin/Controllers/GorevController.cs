using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.StringInfo;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        private readonly IMapper _mapper;

        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService, IMapper mapper)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var models = _mapper.Map<List<GorevListDto>>(_gorevService.GetirAciliyetIleTamamlanmayan());

            return View(models);
        }

        public IActionResult GorevEkle()
        {
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");

            return View(new GorevAddDto());
        }

        [HttpPost]
        public IActionResult GorevEkle(GorevAddDto model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev
                {
                    Aciklama = model.Aciklama,
                    Ad = model.Ad,
                    AciliyetId = model.AciliyetId
                });

                return RedirectToAction("Index");
            }

            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");

            return View(model);
        }

        public IActionResult GorevDuzenle(int id)
        {
            var gorev = _gorevService.GetirIdile(id);

            var model = _mapper.Map<GorevUpdateDto>(gorev);

            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim", gorev.AciliyetId);

            return View(model);
        }

        [HttpPost]
        public IActionResult GorevDuzenle(GorevUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Guncelle(new Gorev()
                {
                    Id = model.Id,
                    Ad = model.Ad,
                    Aciklama = model.Aciklama,
                    AciliyetId = model.AciliyetId
                });

                return RedirectToAction("Index");
            }

            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim", model.AciliyetId);

            return View(model);
        }

        public IActionResult GorevSil(int id)
        {
            _gorevService.Sil(new Gorev { Id = id });

            return Json(null);
        }
    }
}