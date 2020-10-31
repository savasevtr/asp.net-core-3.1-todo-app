using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;

        public GorevController(IGorevService gorevService)
        {
            _gorevService = gorevService;
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
    }
}
