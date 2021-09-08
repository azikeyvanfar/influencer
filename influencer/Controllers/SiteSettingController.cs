using Domain.Contracts;
using Domain.Entities;
using influencer.ViewModels.SiteSetting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace influencer.Controllers
{
    public class SiteSettingController : Controller
    {
        private readonly ISiteSettingRepository _siteSettingRepository;
        private readonly IMemoryCache _memoryCache;

        public SiteSettingController(ISiteSettingRepository siteSettingRepository, IMemoryCache memoryCache)
        {
            _siteSettingRepository = siteSettingRepository;
            _memoryCache = memoryCache;
        }


        public IActionResult Index()
        {
            List<SiteSetting> model = _siteSettingRepository.FindAll().ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult RoleValidationGuid()
        {
            var roleValidationGuidSiteSetting =
                _siteSettingRepository.FindByCondition(t => t.Key == "RoleValidationGuid").FirstOrDefault();

            var model = new RoleValidationGuidViewModel()
            {
                Value = roleValidationGuidSiteSetting?.Value,
                LastTimeChanged = roleValidationGuidSiteSetting?.LastTimeChanged
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult RoleValidationGuid(RoleValidationGuidViewModel model)
        {
            var roleValidationGuidSiteSetting =
                _siteSettingRepository.FindByCondition(t => t.Key == "RoleValidationGuid").FirstOrDefault();

            if (roleValidationGuidSiteSetting == null)
            {
                _siteSettingRepository.Create(new SiteSetting()
                {
                    Key = "RoleValidationGuid",
                    Value = Guid.NewGuid().ToString(),
                    LastTimeChanged = DateTime.Now
                });
            }
            else
            {
                roleValidationGuidSiteSetting.Value = Guid.NewGuid().ToString();
                roleValidationGuidSiteSetting.LastTimeChanged = DateTime.Now;
                _siteSettingRepository.Update(roleValidationGuidSiteSetting);
            }
            _memoryCache.Remove("RoleValidationGuid");

            return RedirectToAction("Index");
        }

    }
}