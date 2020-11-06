﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Entities.Concrete;
using SEProje.ToDo.Web.Areas.Admin.Models;

namespace SEProje.ToDo.Web.Areas.Admin.ViewComponents
{
    public class Wrapper : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public Wrapper(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            AppUserListViewModel model = new AppUserListViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Picture = user.Picture,
                Email = user.Email
            };

            return View(model);
        }
    }
}
