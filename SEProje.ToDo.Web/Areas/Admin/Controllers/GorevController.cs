using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;

        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
        }

        public IActionResult Index()
        {
            List<Gorev> gorevler = _gorevService.GetirHepsi();
            List<GorevListViewModel> models = new List<GorevListViewModel>();

            foreach (var item in gorevler)
            {
                GorevListViewModel model = new GorevListViewModel
                {
                    Id = item.Id,
                    Ad = item.Ad,
                    Aciklama = item.Aciklama,
                    Durum = item.Durum,
                    OlusturmaTarihi = item.OlusturmaTarihi,
                    AciliyetId = item.AciliyetId,
                    Aciliyet = item.Aciliyet
                };

                models.Add(model);
            }

            return View(models);
        }

        public IActionResult GorevEkle()
        {
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim");

            return View(new GorevAddViewModel());
        }

        [HttpPost]
        public IActionResult GorevEkle(GorevAddViewModel model)
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

            return View(model);
        }
    }
}