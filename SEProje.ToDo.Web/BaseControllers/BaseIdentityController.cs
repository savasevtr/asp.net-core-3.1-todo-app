﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.BaseControllers
{
    public class BaseIdentityController : Controller
    {
        protected readonly UserManager<AppUser> _userManager;

        public BaseIdentityController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        protected async Task<AppUser> GetirGirisYapanKullanici()
        {
            return await _userManager.FindByNameAsync(User.Identity.Name);
        }

        protected void HataEkle(IEnumerable<IdentityError> identityErrors)
        {
            foreach (var item in identityErrors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }
    }
}
