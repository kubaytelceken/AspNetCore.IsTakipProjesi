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
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.BaseControllers;
using YSKProje.ToDo.Web.StringInfo;

namespace YSKProje.ToDo.Web.Areas.Member.Controllers
{
    [Area(AreaInfo.Member)]
    [Authorize(Roles = RoleInfo.Member)]
    public class GorevController : BaseIdentityController
    {
        private readonly IGorevService _gorevService;
        private readonly IMapper _mapper;
        public GorevController(IGorevService gorevService,UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _gorevService = gorevService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(int aktifSayfa=1)
        {
            TempData["Active"] = TempDataInfo.Gorev;
            var user = await GetirGirisYapanKullanici();
            var gorevler = _mapper.Map<List<GorevListAllDto>>(_gorevService.GetirTumTablolarlaTamamlanmayan(out int toplamSayfa, user.Id, aktifSayfa));
            ViewBag.ToplamSayfa = toplamSayfa;
            ViewBag.AktifSayfa = aktifSayfa;

            #region Silinen Kısım
            //List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            //foreach (var gorev in gorevler)
            //{
            //    GorevListAllViewModel model = new GorevListAllViewModel();
            //    model.Id = gorev.Id;
            //    model.Aciklama = gorev.Aciklama;
            //    model.Aciliyet = gorev.Aciliyet;
            //    model.Ad = gorev.Ad;
            //    model.AppUser = gorev.AppUser;
            //    model.OlusturulmaTarih = gorev.OlusturulmaTarih;
            //    model.Raporlar = gorev.Raporlar;
            //    models.Add(model);
            //} 
            #endregion

            return View(gorevler);
        }
    }
}
