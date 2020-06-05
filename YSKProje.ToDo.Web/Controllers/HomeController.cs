using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Models;

namespace YSKProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(IGorevService gorevService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _gorevService = gorevService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(AppUserSignInModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {
                        var roller = await _userManager.GetRolesAsync(user);
                        if (roller.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home",new { area="Admin"});
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                    }

                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                }
            }
            return View("Index",model);
        }

        public IActionResult KayitOl()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> KayitOl(AppUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname,

                };
                var result = await _userManager.CreateAsync(user,model.Password);

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
