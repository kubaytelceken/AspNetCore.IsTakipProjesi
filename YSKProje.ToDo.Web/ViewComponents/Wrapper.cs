using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.ViewComponents
{
    public class Wrapper : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBildirimService _bildirimService;
        public Wrapper(UserManager<AppUser> userManager, IBildirimService bildirimService)
        {
            _userManager = userManager;
            _bildirimService = bildirimService;
        }
        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            AppUserListViewModel model = new AppUserListViewModel();
            model.Id = user.Id;
            model.Name = user.Name;
            model.Picture = user.Picture;
            model.Surname = user.Surname;
            model.Email = user.Email;

            var bildirimler = _bildirimService.GetirOkunmayanlar(user.Id).Count ;
            ViewBag.BildirimSayisi = bildirimler;
            var roles = _userManager.GetRolesAsync(user).Result;
            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member", model);

            
        }
    }
}
