using Domain.Contracts;
using Domain.Entities;
using influencer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;

namespace influencer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserArticleRepository _userArticleRepository;
        private readonly IAdvertiseRepository _advertiseRepository;
        private readonly ILanguagesRepository _languagesRepository;
        private readonly ITeamRepository _TeamRepository;
        public HomeController(ILogger<HomeController> logger, IUserArticleRepository userArticleRepository, IAdvertiseRepository advertiseRepository, ILanguagesRepository languagesRepository, ITeamRepository TeamRepository)
        {
            _logger = logger;
            _userArticleRepository = userArticleRepository;
            _advertiseRepository = advertiseRepository;
            _languagesRepository = languagesRepository;
            _TeamRepository = TeamRepository;
        }

        public IActionResult Index(string alertSuccess)
        {
            string lang = CultureInfo.CurrentCulture.Name;
            List<UserArticle> article = _userArticleRepository.FindByCondition(m=>m.Language.LanguageTitle == lang).OrderBy(m=>m.OrderArticle).ToList();
            ViewBag.ListAdv = _advertiseRepository.SelectAllWithInsta();
            ViewBag.ListTeam = _TeamRepository.FindByCondition(m => m.Language.LanguageTitle == lang).OrderBy(m => m.OrderTeam).ToList();
            ViewBag.alertSuccess = alertSuccess;
            return View(article);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Manage()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Languages()
        {
            List<Languages> languages = _languagesRepository.FindAll().ToList();
            return PartialView(languages);
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            Redirect(Request.Headers["Referer"].ToString());
            return RedirectToAction("Index");
        }
    }
}
