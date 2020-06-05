using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Rendering;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;
        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
            List<Gorev> gorevler = _gorevService.GetirAciliyetIleTamamlanmayan();
            List<GorevListViewModel> model = new List<GorevListViewModel>();
            foreach (var item in gorevler)
            {
                GorevListViewModel gorevModel = new GorevListViewModel();
                gorevModel.Id = item.Id;
                gorevModel.Ad = item.Ad;
                gorevModel.Aciklama = item.Aciklama;
                gorevModel.Aciliyet = item.Aciliyet;
                gorevModel.AciliyetId = item.AciliyetId;
                gorevModel.Durum = item.Durum;
                gorevModel.OlusturulmaTarih = item.OlusturulmaTarih; 

                model.Add(gorevModel);
            }
            return View(model);
        }

        public IActionResult EkleGorev()
        {
            TempData["Active"] = "gorev";
            ViewBag.Aciliyetler =new SelectList(_aciliyetService.GetirHepsi(),"Id","Tanim");
            return View(new GorevAddViewModel());
        }
        [HttpPost]
        public IActionResult EkleGorev(GorevAddViewModel model)
        {
           if (ModelState.IsValid)
           {
               _gorevService.Kaydet(new Gorev()
               {
                   Ad = model.Ad,
                   Aciklama=model.Aciklama,
                   AciliyetId = model.AciliyetId
               });

               return RedirectToAction("Index");
           }

           return View(model);
        }


        public IActionResult GuncelleGorev(int id)
        {
            TempData["Active"] = "gorev";
            var gorev = _gorevService.GetirIdile(id);
            GorevUpdateViewModel model = new GorevUpdateViewModel
            {
                Id = gorev.Id,
                Aciklama = gorev.Aciklama,
                AciliyetId = gorev.AciliyetId,
                Ad = gorev.Ad
            };
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim",gorev.AciliyetId);
            return View(model);
        }
        [HttpPost]
        public IActionResult GuncelleGorev(GorevUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Guncelle(new Gorev()
                {
                    Id = model.Id,
                    Ad = model.Ad,
                    Aciklama = model.Aciklama,
                    AciliyetId = model.AciliyetId
                }); 

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult SilGorev(int id)
        {
            _gorevService.Sil(new Gorev { Id =id });
            return Json(null);
        }

    }
}
