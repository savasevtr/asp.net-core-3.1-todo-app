using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.BaseControllers;
using System;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Controllers
{
    public class HomeController : BaseIdentityController
    {
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager) : base(userManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserSignInDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                if (user != null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);

                    if (identityResult.Succeeded)
                    {
                        var roller = await _userManager.GetRolesAsync(user);

                        if (roller.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                    }

                    if (identityResult.IsNotAllowed)
                    {

                    }

                    if (identityResult.IsLockedOut)
                    {

                    }
                }

                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı!");
            }

            return View(model);
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KayitOl(AppUserAddDto model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(user, "Member");

                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                    HataEkle(addRoleResult.Errors);
                }

                HataEkle(result.Errors);
            }

            return View(model);
        }

        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }

        public IActionResult StatusCode(int? code)
        {
            if (code == 404)
            {
                ViewBag.Code = code;
                ViewBag.Message = "Sayfa Bulunamadı!";
            }

            return View();
        }

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            ViewBag.Path = exceptionHandlerPathFeature.Path;
            ViewBag.Message = exceptionHandlerPathFeature.Error.Message;

            return View();
        }

        public void Hata()
        {
            throw new Exception("Test hata mesajı");
        }
    }
}