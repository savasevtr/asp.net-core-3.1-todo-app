using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Models;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View(new AppUserSignInViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserSignInViewModel model)
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
            return View(new AppUserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> KayitOl(AppUserRegisterViewModel model)
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

                    foreach (var item in addRoleResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index");
        }
    }
}