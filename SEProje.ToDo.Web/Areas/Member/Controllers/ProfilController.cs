using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;
using SEProje.ToDo.Entities.Concrete;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class ProfilController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        public ProfilController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var model = _mapper.Map<AppUserListDto>(await _userManager.FindByNameAsync(User.Identity.Name));

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserListDto model, IFormFile Picture)
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