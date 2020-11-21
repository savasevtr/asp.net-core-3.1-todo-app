using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SEProje.ToDo.Business.Interfaces;
using SEProje.ToDo.DTO.DTOs.GorevDTOs;
using SEProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SEProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public GorevController(IGorevService gorevService, UserManager<AppUser> userManager, IMapper mapper)
        {
            _gorevService = gorevService;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarlaTamamlanan(out int pageCount, user.Id, page));

            ViewBag.pageCount = pageCount;
            ViewBag.currentPage = page;

            return View(model);
        }
    }
}
