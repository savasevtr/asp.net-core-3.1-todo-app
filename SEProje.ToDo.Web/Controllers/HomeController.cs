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

        public HomeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(new AppUserSignInViewModel());
        }

        [HttpPost]
        public IActionResult Index(AppUserSignInViewModel model)
        {
            if (ModelState.IsValid)
            {

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
    }
}