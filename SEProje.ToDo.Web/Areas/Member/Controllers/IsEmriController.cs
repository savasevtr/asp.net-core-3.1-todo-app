using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.Web.Areas.Admin.Models;
using System.Collections.Generic;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class IsEmriController : Controller
    {
        private readonly IGorevService _gorevService;

        public IsEmriController(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }

        public IActionResult Index(int id)
        {
            var gorevler = _gorevService.GetirTumTablolarla(x => x.AppUserId == id && !x.Durum);

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
                    Raporlar = item.Raporlar,
                    OlusturmaTarihi = item.OlusturmaTarihi,
                };

                models.Add(model);
            }

            return View(models);
        }
    }
}