﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.DTO.DTOs.AppUserDTOs;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.BaseControllers;
using SEProje.ToDo.Web.StringInfo;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class ProfilController : BaseIdentityController
    {
        private readonly IMapper _mapper;

        public ProfilController(UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<AppUserListDto>(await GetirGirisYapanKullanici()));
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

                HataEkle(result.Errors);
            }

            return View(model);
        }

    }
}