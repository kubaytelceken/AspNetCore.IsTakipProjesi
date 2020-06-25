using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using YSKProje.ToDo.Business.Interfaces;
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;
using YSKProje.ToDo.Entities.Concrete;
using YSKProje.ToDo.Web.Areas.Admin.Models;

namespace YSKProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AciliyetController : Controller
    {
        private readonly IAciliyetService _aciliyetService;
        private readonly IMapper _mapper;
        public AciliyetController(IAciliyetService aciliyetService, IMapper mapper)
        {
            _aciliyetService = aciliyetService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "aciliyet";
            //List<Aciliyet> aciliyetler = _aciliyetService.GetirHepsi();
            //List<AciliyetListViewModel> model = new List<AciliyetListViewModel>();
            //foreach (var item in aciliyetler)
            //{
            //    AciliyetListViewModel aciliyetModel = new AciliyetListViewModel();
            //    aciliyetModel.Id = item.Id;
            //    aciliyetModel.Tanim = item.Tanim;

            //    model.Add(aciliyetModel);
            //}
            
            return View(_mapper.Map<List<AciliyetListDto>>(_aciliyetService.GetirHepsi()));
        }


        public IActionResult EkleAciliyet()
        {
            TempData["Active"] = "aciliyet";
            return View(new AciliyetAddDto());
        }
        [HttpPost]
        public IActionResult EkleAciliyet(AciliyetAddDto model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Kaydet(new Aciliyet()
                {
                    Tanim = model.Tanim
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult GuncelleAciliyet(int id)
        {
            TempData["Active"] = "aciliyet";
            //var aciliyet = _aciliyetService.GetirIdile(id);
            //AciliyetUpdateViewModel model = new AciliyetUpdateViewModel
            //{
            //    Id = aciliyet.Id,
            //    Tanim = aciliyet.Tanim
            //};
            
            return View(_mapper.Map<AciliyetUpdateDto>(_aciliyetService.GetirIdile(id)));
        }

        [HttpPost]
        public IActionResult GuncelleAciliyet(AciliyetUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Guncelle(new Aciliyet()
                {
                    Id = model.Id,
                    Tanim = model.Tanim
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
