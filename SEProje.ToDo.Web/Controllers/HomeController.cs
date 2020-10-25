using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Web.Extensions;
using SEProje.ToDo.Web.Filters;
using SEProje.ToDo.Web.Logger;
using SEProje.ToDo.Web.Models;

namespace SEProje.ToDo.Web.Controllers
{
    // [Route("kisiler/[action]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.isim = "Savaş";
            TempData["isim"] = "Ramo";
            ViewData["isim"] = "Deli Veli";

            // SetCookie();
            // ViewBag.Cookie = GetCookie();

            SetSession();
            ViewBag.Session = GetSession();

            return View(new List<MusteriViewModel>
            {
                new MusteriViewModel() { Ad = "Ali" },
                new MusteriViewModel() { Ad = "Ramo" },
                new MusteriViewModel() { Ad = "Cemo" },
                new MusteriViewModel() { Ad = "Memo" },
                new MusteriViewModel() { Ad = "Ayşo" },
            });
        }

        public IActionResult Sonuc()
        {
            return View();
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [CustomFilters]
        [HttpPost]
        public IActionResult KayitOl(KullaniciKayitViewModel model)
        {
            //string ad = HttpContext.Request.Form["Ad"].ToString();
            //ViewBag.Ad = ad;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }

        public void SetCookie()
        {
            HttpContext.Response.Cookies.Append("kisi", "savasev", new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Expires = DateTime.Now.AddDays(20),
                HttpOnly = true,
                SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict,
                // Secure = true // https (ssl)
            });
        }

        public string GetCookie()
        {
            return HttpContext.Request.Cookies["kisi"];
        }

        public void SetSession()
        {
            // HttpContext.Session.SetString("kisi", "savas.ev");
            // HttpContext.Session.SetObject("kisi", "savas.ev");
            HttpContext.Session.SetObject("kisi", new KullaniciKayitViewModel()
            {
                Ad = "Savaş",
                Soyad = "Ev"
            });
        }

        public KullaniciKayitViewModel GetSession()
        {
            // return HttpContext.Session.GetString("kisi");
            // return HttpContext.Session.GetObject<string>("kisi");
            return HttpContext.Session.GetObject<KullaniciKayitViewModel>("kisi");
        }

        public IActionResult PageError(int code)
        {
            ViewBag.Code = code;

            if (code == 404)
            {
                ViewBag.ErrorMessage = "Sayfa bulunamadı";
            }

            return View();
        }

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            NLogLogger nLogLogger = new NLogLogger();
            nLogLogger.LogWithNLog($"hatanın oluştuğu yer : {exceptionHandlerPathFeature.Path} \n hata mesajı : {exceptionHandlerPathFeature.Error.Message} \n stack trace : {exceptionHandlerPathFeature.Error.StackTrace} \n\n");

            ViewBag.Path = exceptionHandlerPathFeature.Path;
            ViewBag.Message = exceptionHandlerPathFeature.Error.Message;

            return View();
        }

        public IActionResult Hata()
        {
            throw new Exception("Hata Oluştu!");
        }
    }
}
