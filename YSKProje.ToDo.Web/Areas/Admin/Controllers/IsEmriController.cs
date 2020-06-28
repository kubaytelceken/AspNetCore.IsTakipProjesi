using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;
using YSKProje.ToDo.DTO.DTOs.RaporDtos;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.BaseControllers;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly IDosyaService _dosyaService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;

        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, 
            UserManager<AppUser> userManager, IDosyaService dosyaService, IBildirimService bildirimService, IMapper mapper):base(userManager)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _dosyaService = dosyaService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            #region Silinen Kısım
            //List<Gorev> gorevler = _gorevService.GetirTumTablolarla();
            //List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            //foreach (var item in gorevler)
            //{
            //    GorevListAllViewModel model = new GorevListAllViewModel();
            //    model.Id = item.Id;
            //    model.Aciklama = item.Aciklama;
            //    model.Aciliyet = item.Aciliyet;
            //    model.Ad = item.Ad;
            //    model.AppUser = item.AppUser;
            //    model.OlusturulmaTarih = item.OlusturulmaTarih;
            //    model.Raporlar = item.Raporlar;

            //    models.Add(model);
            //} 
            #endregion
            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla()));
        }



        public IActionResult Detaylandir(int id)
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            #region Silinen Kısım
            //var gorev = _gorevService.GetirRaporlarileId(id);
            //GorevListAllViewModel model = new GorevListAllViewModel();
            //model.Id = gorev.Id;
            //model.Raporlar = gorev.Raporlar;
            //model.Aciklama = gorev.Aciklama;
            //model.AppUser = gorev.AppUser;
            //model.Ad = gorev.Ad; 
            #endregion
            return View(_mapper.Map<GorevListAllDto>(_gorevService.GetirRaporlarileId(id)));
        }
        public IActionResult GetirExcel(int id)
        {
            return File(_dosyaService.AktarExcel(_mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(id).Raporlar)), 
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlxs");
        }
        public IActionResult GetirPdf(int id)
        {
            var path = _dosyaService.AktarPdf(_mapper.Map<List<RaporDosyaDto>>(_gorevService.GetirRaporlarileId(id).Raporlar));
            return File(path,"application/pdf", Guid.NewGuid() + ".pdf");
        }

        public IActionResult AtaPersonel(int id,string s,int sayfa=1)
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            ViewBag.Aktifsayfa = sayfa;
            //ViewBag.Toplamsayfa = (int)Math.Ceiling((double)_appUserService.getirAdminOlmayanlar().Count / 3);
            ViewBag.Aranan = s;

            var personeller = _mapper.Map<List<AppUserListDto>>(_appUserService.getirAdminOlmayanlar(out int toplamsayfa, s, sayfa));

            ViewBag.Toplamsayfa = toplamsayfa;
            #region Silinen Kısım
            //List<AppUserListViewModel> personelModel = new List<AppUserListViewModel>();
            //foreach (var item in personeller)
            //{
            //    AppUserListViewModel model = new AppUserListViewModel();
            //    model.Id = item.Id;
            //    model.Name = item.Name;
            //    model.Surname = item.Surname;
            //    model.Email = item.Email;
            //    model.Picture = item.Picture;
            //    personelModel.Add(model);
            //} 
            #endregion
            ViewBag.Personeller = personeller;

            //var gorev = _gorevService.GetirAciliyetIdIle(id);

            #region Silinen Kısım
            //GorevListViewModel gorevModel = new GorevListViewModel();
            //gorevModel.Id = gorev.Id;
            //gorevModel.Ad = gorev.Ad;
            //gorevModel.Aciklama = gorev.Aciklama;
            //gorevModel.Aciliyet = gorev.Aciliyet;
            //gorevModel.OlusturulmaTarih = gorev.OlusturulmaTarih; 
            #endregion
            return View(_mapper.Map<GorevListDto>(_gorevService.GetirAciliyetIdIle(id)));
        }


        //bildirim gönderilecek.
        [HttpPost]
        public IActionResult AtaPersonel(PersonelGorevlendirDto model)
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

        public IActionResult GorevlendirPersonel(PersonelGorevlendirDto model)
        {
            TempData["Active"] = TempDataInfo.IsEmri;



            //var userModel = 
            #region Silinen Kısım
            //var user = _userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId);
            //AppUserListViewModel userModel = new AppUserListViewModel();
            //userModel.Id = user.Id;
            //userModel.Name = user.Name;
            //userModel.Picture = user.Picture;
            //userModel.Surname = user.Surname;
            //userModel.Email = user.Email; 
            #endregion

            //var gorevModel = 
            #region Silinen Kısım
            //var gorev = _gorevService.GetirAciliyetIdIle(model.GorevId);
            //GorevListViewModel gorevModel = new GorevListViewModel();
            //gorevModel.Id = gorev.Id;
            //gorevModel.Aciklama = gorev.Aciklama;
            //gorevModel.Aciliyet = gorev.Aciliyet;
            //gorevModel.Ad = gorev.Ad; 
            #endregion


            PersonelGorevlendirListDto personelGorevlendirModel = new PersonelGorevlendirListDto
            {
                AppUser = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(I => I.Id == model.PersonelId)),
                Gorev = _mapper.Map<GorevListDto>(_gorevService.GetirAciliyetIdIle(model.GorevId))
            };
            return View(personelGorevlendirModel);
        }

    }
}
