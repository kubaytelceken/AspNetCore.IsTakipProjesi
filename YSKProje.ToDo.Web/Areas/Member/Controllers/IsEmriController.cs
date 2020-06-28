using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.GorevDtos;
using YSKProje.ToDo.DTO.DTOs.RaporDtos;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.BaseControllers;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class IsEmriController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;
        private readonly IRaporService _raporService;
        private readonly IBildirimService _bildirimService;
        private readonly IMapper _mapper;
        public IsEmriController(IGorevService gorevService, UserManager<AppUser> userManager, IRaporService raporService, IBildirimService bildirimService, IMapper mapper) : base(userManager)
        {
            _gorevService = gorevService;
            _raporService = raporService;
            _bildirimService = bildirimService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            var user = await GetirGirisYapanKullanici();
            //var gorev = _gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && !I.Durum);
            #region Silinen Kısım
            //List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            //foreach (var item in gorev)
            //{
            //    GorevListAllViewModel model = new GorevListAllViewModel();
            //    model.Id = item.Id;
            //    model.Ad = item.Ad;
            //    model.Aciliyet = item.Aciliyet;
            //    model.Aciklama = item.Aciklama;
            //    model.AppUser = item.AppUser;
            //    model.Raporlar = item.Raporlar;
            //    model.OlusturulmaTarih = item.OlusturulmaTarih;
            //    models.Add(model);
            //} 
            #endregion
            return View(_mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarla(I => I.AppUserId == user.Id && !I.Durum)));
        }

        public IActionResult EkleRapor(int id)
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            var gorev = _gorevService.GetirAciliyetIdIle(id);
            RaporAddDto model = new RaporAddDto
            {
                GorevId = id,
                Gorev = gorev
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EkleRapor(RaporAddDto model)
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            if (ModelState.IsValid)
            {
                _raporService.Kaydet(new Rapor()
                {
                    GorevId = model.GorevId,
                    Detay = model.Detay,
                    Tanim=model.Tanim
                });
                var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
                var aktifKullanici = await GetirGirisYapanKullanici();
                foreach (var admin in adminUserList)
                {
                    _bildirimService.Kaydet(new Bildirim
                    {
                        Aciklama=$"{aktifKullanici.Name} {aktifKullanici.Surname} yeni bir rapor yazdı.",
                        AppUserId = admin.Id
                        
                    });
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }


        public IActionResult GuncelleRapor(int id)
        {
            TempData["Active"] = TempDataInfo.IsEmri;
            var rapor =  _raporService.GetirGorevIleId(id);
            RaporUpdateDto model = new RaporUpdateDto
            {
                Id = rapor.Id,
                Tanim = rapor.Tanim,
                Detay = rapor.Detay,
                GorevId = rapor.GorevId,
                Gorev = rapor.Gorev
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult GuncelleRapor(RaporUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var guncellenecekRapor = _raporService.GetirGorevIleId(model.Id);
                guncellenecekRapor.GorevId = model.GorevId;
                guncellenecekRapor.Tanim = model.Tanim;
                guncellenecekRapor.Detay = model.Detay;
                _raporService.Guncelle(guncellenecekRapor);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> TamamlaGorev(int gorevId)
        {
            var guncellenecekGorev = _gorevService.GetirIdile(gorevId);
            guncellenecekGorev.Durum = true;
            _gorevService.Guncelle(guncellenecekGorev);
            var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");
            var aktifKullanici = await GetirGirisYapanKullanici();
            foreach (var admin in adminUserList)
            {
                _bildirimService.Kaydet(new Bildirim
                {
                    Aciklama = $"{aktifKullanici.Name} {aktifKullanici.Surname} vermiş olduğunuz bir görevi tamamladı.",
                    AppUserId = admin.Id

                });
            }
            return Json(null);
        }
    }
}
