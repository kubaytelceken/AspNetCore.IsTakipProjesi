using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class ProfilController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public ProfilController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "profil";
            var appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserListViewModel model = new AppUserListViewModel();
            model.Id = appUser.Id;
            model.Name = appUser.Name;
            model.Surname = appUser.Surname;
            model.Email = appUser.Email;
            model.Picture = appUser.Picture;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserListViewModel model,IFormFile resim)
        {
            if (ModelState.IsValid)
            {
                var guncellenecekKullanici = _userManager.Users.FirstOrDefault(I => I.Id == model.Id);
                if (resim != null)
                {
                    string uzanti = Path.GetExtension(resim.FileName);
                    string resimAd = Guid.NewGuid()+uzanti;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + resimAd);
                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await resim.CopyToAsync(stream);
                    }
                    guncellenecekKullanici.Picture = resimAd;
                }
                guncellenecekKullanici.Name = model.Name;
                guncellenecekKullanici.Email = model.Email;
                guncellenecekKullanici.Surname = model.Surname;

                var identiyResult = await _userManager.UpdateAsync(guncellenecekKullanici);
                if (identiyResult.Succeeded)
                {
                    TempData["message"] = "Güncelleme işleminiz başarıyla gerçekleşmiştir.";
                    return RedirectToAction("Index");
                }
                foreach (var item in identiyResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }

    }
}
