using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class HomeController : Controller
    {
        /*
         * İlgili kullanıcının yazdığı rapor sayısı
         * ilgili kullanıcının tamamaladıgı görev sayısı
         * ilgili kullanıcının okumadıgı bildirim sayısı
         * ilgili kullanıcının tamamlaması gereken görev sayısı
         */
        private readonly IRaporService _raporService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        public HomeController(IRaporService raporService, UserManager<AppUser> userManager, IGorevService gorevService, IBildirimService bildirimService)
        {
            _raporService = raporService;
            _userManager = userManager;
            _gorevService = gorevService;
            _bildirimService = bildirimService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["active"] = "anasayfa";
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiIleAppUserId(user.Id);
            ViewBag.OkunmayanBildirimSayisi = _bildirimService.GetirOkunmayanSayisiIleAppUserId(user.Id);
            ViewBag.GorevSayisiTamamlanan = _gorevService.GetirGorevSayisiTamamlananIleAppUserId(user.Id);
            ViewBag.GorevSayisiTamamlamasiGereken = _gorevService.GetirGorevSayisiTamamlanmasiGerekenIleAppUserId(user.Id);

            return View();
        }
    }
}
