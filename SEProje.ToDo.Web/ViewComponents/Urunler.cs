using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.ViewComponents
{
    public class Urunler : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("Yeni", new List<MusteriViewModel>
            {
                new MusteriViewModel() { Ad = "Ali" },
                new MusteriViewModel() { Ad = "Ramo" },
                new MusteriViewModel() { Ad = "Cemo" },
                new MusteriViewModel() { Ad = "Memo" },
                new MusteriViewModel() { Ad = "Ayşo" },
            });
        }
    }
}
