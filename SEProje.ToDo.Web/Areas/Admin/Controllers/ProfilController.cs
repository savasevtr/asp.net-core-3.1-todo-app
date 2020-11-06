using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProfilController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfilController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var appUer = await _userManager.FindByNameAsync(User.Identity.Name);

            AppUserListViewModel appUserListViewModel = new AppUserListViewModel
            {
                Id = appUer.Id,
                Name = appUer.Name,
                Surname = appUer.Surname,
                Email = appUer.Email,
                Picture = appUer.Picture
            };

            return View(appUserListViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserListViewModel model, IFormFile Picture)
        {
            if (ModelState.IsValid)
            {
                var _user = _userManager.Users.FirstOrDefault(x => x.Id == model.Id);

                if (Picture != null)
                {
                    string fileExtension = Path.GetExtension(Picture.FileName);

                    string pictureName = Guid.NewGuid() + fileExtension;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + pictureName);

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await Picture.CopyToAsync(fileStream);
                    }

                    _user.Picture = pictureName;
                }

                _user.Name = model.Name;
                _user.Surname = model.Surname;
                _user.Email = model.Email;

                var result = await _userManager.UpdateAsync(_user);

                if (result.Succeeded)
                {
                    TempData["message"] = "Profiliniz başarılı bir şekilde güncellendi";

                    return RedirectToAction("Index");
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