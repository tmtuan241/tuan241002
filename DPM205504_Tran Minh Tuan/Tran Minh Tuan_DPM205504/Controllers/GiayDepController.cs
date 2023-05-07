using AutoMapper;
using DPM205488_LMT.Models;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace DPM205488_LMT.Controllers
{
    public class GiayDepController : Controller
    {
        private readonly IGiayDepService giayDepService;
        private readonly IMapper mapper;
        public GiayDepController(IGiayDepService giayDepService, IMapper mapper)
        {
            this.giayDepService = giayDepService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(giayDepService.GetGiayDeps());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            GiayDepViewModel data = new GiayDepViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI GIAY DEP" : "CẬP NHẬT GIAY DEP";

            if (id != 0)
            {
                GiayDep res = giayDepService.GetGiayDep(id);
                data = mapper.Map<GiayDepViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, GiayDepViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (ModelState.IsValid)
            {
                try
                {
                    GiayDep res = mapper.Map<GiayDep>(data);
                    if (id != 0)
                    {
                        giayDepService.UpdateGiayDep(res);
                    }
                    else
                    {

                        giayDepService.InsertGiayDep(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "GiayDep");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            GiayDep res = giayDepService.GetGiayDep(id);
            giayDepService.DeleteGiayDep(res);

            return RedirectToAction("Index", "GiayDep");
        }
    }
}
