using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.BaseControllers;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = RoleInfo.Member)]
    [Area(AreaInfo.Member)]
    public class HomeController : BaseIdentityController
    {
        /*
         * İlgili kullanıcının yazdığı rapor sayısı
         * ilgili kullanıcının tamamaladıgı görev sayısı
         * ilgili kullanıcının okumadıgı bildirim sayısı
         * ilgili kullanıcının tamamlaması gereken görev sayısı
         */
        private readonly IRaporService _raporService;
        private readonly IGorevService _gorevService;
        private readonly IBildirimService _bildirimService;
        public HomeController(IRaporService raporService, UserManager<AppUser> userManager, IGorevService gorevService, IBildirimService bildirimService) : base(userManager)
        {
            _raporService = raporService;
            _gorevService = gorevService;
            _bildirimService = bildirimService;
        }
        public async Task<IActionResult> Index()
        {
            TempData["active"] = TempDataInfo.Anasayfa;
            var user = await GetirGirisYapanKullanici();
            ViewBag.RaporSayisi = _raporService.GetirRaporSayisiIleAppUserId(user.Id);
            ViewBag.OkunmayanBildirimSayisi = _bildirimService.GetirOkunmayanSayisiIleAppUserId(user.Id);
            ViewBag.GorevSayisiTamamlanan = _gorevService.GetirGorevSayisiTamamlananIleAppUserId(user.Id);
            ViewBag.GorevSayisiTamamlamasiGereken = _gorevService.GetirGorevSayisiTamamlanmasiGerekenIleAppUserId(user.Id);

            return View();
        }
    }
}
