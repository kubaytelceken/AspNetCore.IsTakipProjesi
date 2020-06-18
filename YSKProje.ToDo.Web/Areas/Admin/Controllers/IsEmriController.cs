using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class IsEmriController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, 
            UserManager<AppUser> userManager, IDosyaService dosyaService, IBildirimService bildirimService)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _userManager = userManager;
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "isemri";
            List<Gorev> gorevler = _gorevService.GetirTumTablolarla();
            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.Id = item.Id;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.Ad = item.Ad;
                model.AppUser = item.AppUser;
                model.OlusturulmaTarih = item.OlusturulmaTarih;
                model.Raporlar = item.Raporlar;

                models.Add(model);
            }
            return View(models);
        }



        public IActionResult Detaylandir(int id)
        {
            TempData["Active"] = "isemri";
            var gorev = _gorevService.GetirRaporlarileId(id);
            GorevListAllViewModel model = new GorevListAllViewModel();
            model.Id = gorev.Id;
            model.Raporlar = gorev.Raporlar;
            model.Aciklama = gorev.Aciklama;
            model.AppUser = gorev.AppUser;
            model.Ad = gorev.Ad;
            return View(model);
        }
        public IActionResult GetirExcel(int id)
        {
            return File(_dosyaService.AktarExcel(_gorevService.GetirRaporlarileId(id).Raporlar), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlxs");
        }
        public IActionResult GetirPdf(int id)
        {
            var path = _dosyaService.AktarPdf(_gorevService.GetirRaporlarileId(id).Raporlar);
            return File(path,"application/pdf", Guid.NewGuid() + ".pdf");
        }

        public IActionResult AtaPersonel(int id,string s,int sayfa=1)
        {
            TempData["Active"] = "isemri";
            ViewBag.Aktifsayfa = sayfa;
            //ViewBag.Toplamsayfa = (int)Math.Ceiling((double)_appUserService.getirAdminOlmayanlar().Count / 3);
            ViewBag.Aranan = s;
            int toplamsayfa;
            var gorev = _gorevService.GetirAciliyetIdIle(id);
            var personeller = _appUserService.getirAdminOlmayanlar(out toplamsayfa,s, sayfa);
            ViewBag.Toplamsayfa = toplamsayfa;
            List<AppUserListViewModel> personelModel = new List<AppUserListViewModel>();
            foreach (var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.Surname = item.Surname;
                model.Email = item.Email;
                model.Picture = item.Picture;
                personelModel.Add(model);
            }
            ViewBag.Personeller = personelModel;
            GorevListViewModel gorevModel = new GorevListViewModel();
            gorevModel.Id = gorev.Id;
            gorevModel.Ad = gorev.Ad;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;
            gorevModel.OlusturulmaTarih = gorev.OlusturulmaTarih;
            return View(gorevModel);
        }


        //bildirim gönderilecek.
        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevlendirViewModel model)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(model.GorevId);
            guncellenecekGorev.AppUserId = model.PersonelId;
            _gorevService.Guncelle(guncellenecekGorev);

            _bildirimService.Kaydet(new Bildirim
            {
                AppUserId = model.PersonelId,
                Aciklama = $"{guncellenecekGorev.Ad} adlı iş için görevlendirildiniz."
            });
            
            return RedirectToAction("Index");
        }

        public IActionResult GorevlendirPersonel(PersonelGorevlendirViewModel model)
        {
            TempData["Active"] = "isemri";
            var user = _userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId);
            var gorev = _gorevService.GetirAciliyetIdIle(model.GorevId);

            AppUserListViewModel userModel = new AppUserListViewModel();
            userModel.Id = user.Id;
            userModel.Name = user.Name;
            userModel.Picture = user.Picture;
            userModel.Surname = user.Surname;
            userModel.Email = user.Email;

            GorevListViewModel gorevModel = new GorevListViewModel();
            gorevModel.Id = gorev.Id;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;
            gorevModel.Ad = gorev.Ad;


            PersonelGorevlendirListViewModel personelGorevlendirModel = new PersonelGorevlendirListViewModel();
            personelGorevlendirModel.AppUser = userModel;
            personelGorevlendirModel.Gorev = gorevModel;
            return View(personelGorevlendirModel);
        }

    }
}
