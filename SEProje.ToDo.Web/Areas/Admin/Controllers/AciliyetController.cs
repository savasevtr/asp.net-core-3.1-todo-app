using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AciliyetController : Controller
    {
        private readonly IAciliyetService _aciliyetService;

        public AciliyetController(IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
        }

        public IActionResult Index()
        {
            List<Aciliyet> aciliyetler = _aciliyetService.GetirHepsi();

            List<AciliyetListViewModel> model = new List<AciliyetListViewModel>();

            foreach (var item in aciliyetler)
            {
                AciliyetListViewModel aciliyetListViewModel = new AciliyetListViewModel();
                aciliyetListViewModel.Id = item.Id;
                aciliyetListViewModel.Tanim = item.Tanim;
                model.Add(aciliyetListViewModel);
            }

            return View(model);
        }

        public IActionResult AciliyetEkle()
        {
            return View(new AciliyetAddViewModel());
        }

        [HttpPost]
        public IActionResult AciliyetEkle(AciliyetAddViewModel model)
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
            var aciliyet = _aciliyetService.GetirIdile(id);

            AciliyetEditViewModel model = new AciliyetEditViewModel
            {
                Id = aciliyet.Id,
                Tanim = aciliyet.Tanim
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AciliyetDuzenle(AciliyetEditViewModel model)
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