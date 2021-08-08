using Domain.Contracts;
using Domain.Contracts.FORG;
using Domain.Entities.FSYS;
using EndPoint.WebUI.App_Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace EndPoint.WebUI.Controllers
{
    public class BasicDataController : BaseController<BasicDataController>
    {

        private readonly IBasicDataRepository _BasicDataRepo;
        

        public BasicDataController(ILogger<BasicDataController> logger,IBasicDataRepository BasicDataRepo, IConfiguration config, IHttpContextAccessor httpContextAccessor) : base(config, httpContextAccessor, logger)
        {
            _BasicDataRepo = BasicDataRepo;
        }
        public IActionResult BasicDataIndex(string GroupKey)
        {
            ViewBag.GroupKey = GroupKey;
            return View();
        }

        [HttpPost]
        public ActionResult BasicDataList(string filter, int pageNumber, int pageSize, string groupKey, bool refresh)
        {

            if (filter == null)
            {
                filter = "";
            }
            Guid compayId = Guid.Parse(HttpContext.Request.Cookies["CompanyId"]);
            List<BasicDataList> ListBasicData = _BasicDataRepo.GetBasicData(filter, pageNumber, pageSize, groupKey,compayId);
            ViewBag.Refresh = refresh;
            ViewBag.PowerUser = HttpContext.Request.Cookies["PowerUser"];
            return PartialView(ListBasicData);
        }

        public IActionResult Add(string groupKey)
        {
            List<BasicData> listBd = _BasicDataRepo.GetAll();
            SelectList BasicDataList = new SelectList(listBd, "Text", "Value");
            ViewBag.BasicDataList = BasicDataList;
            ViewBag.GroupKey = groupKey;
            ViewBag.PowerUser = HttpContext.Request.Cookies["PowerUser"];
            return View("BasicData");
        }
        [HttpPost]
        public IActionResult AddToDb(BasicData BasicData)
        {
            if (ModelState.IsValid)
            {
                int res = _BasicDataRepo.InsetToBasicData(BasicData);
                bool resBool;
                if (res != null)
                {
                    resBool = true;
                }
                else
                {
                    resBool = false;
                }
                return Json(new { success = resBool });
            }
            return RedirectToAction("Add");
        }
        public IActionResult Edit(Guid id)
        {
            BasicData BasicData = _BasicDataRepo.Fetch(id);
            ViewBag.GroupKey = BasicData.GroupKey;
            ViewBag.PowerUser = HttpContext.Request.Cookies["PowerUser"];
            return View("BasicData", BasicData);
        }
        [HttpPost]
        public IActionResult EditToDb(BasicData BasicData)
        {
            if (ModelState.IsValid)
            {
                bool res = _BasicDataRepo.Update(BasicData);
                return Json(new { success = res });
            }
            else
            {
                List<BasicData> listBd = _BasicDataRepo.GetAll();
                SelectList basicData = new SelectList(listBd, "Text", "Value");
                return View("BasicData", basicData);
            }
        }
        public IActionResult Delete(Guid id)
        {
            _BasicDataRepo.Delete(new BasicData() { BasicDataId = id });
            return Json(new { success = true });
        }
        public IActionResult UpViewOrder(Guid currentId,int currentOrder,Guid oldId,int oldOrder )
        {
            int res = _BasicDataRepo.UpViewOrder(currentId, currentOrder, oldId, oldOrder);
            bool resBool;
            if (res != 0)
            {
                resBool = true;
            }
            else
            {
                resBool = false;
            }
            return Json(new { success = resBool });

        }
        public IActionResult DownViewOrder(Guid currentId, int currentOrder, Guid NextId, int NextOrder)
        {
            int res = _BasicDataRepo.DownViewOrder(currentId, currentOrder, NextId, NextOrder);
            bool resBool;
            if (res != 0)
            {
                resBool = true;
            }
            else
            {
                resBool = false;
            }
            return Json(new { success = resBool });
        }

    }
}