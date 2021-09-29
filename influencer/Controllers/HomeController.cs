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
using System.Linq;

namespace influencer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserArticleRepository _userArticleRepository;
        private readonly IAdvertiseRepository _advertiseRepository;
        private readonly ILanguagesRepository _languagesRepository;
        public HomeController(ILogger<HomeController> logger, IUserArticleRepository userArticleRepository, IAdvertiseRepository advertiseRepository, ILanguagesRepository languagesRepository)
        {
            _logger = logger;
            _userArticleRepository = userArticleRepository;
            _advertiseRepository = advertiseRepository;
            _languagesRepository = languagesRepository;
        }

        public IActionResult Index()
        {
            List<UserArticle> article = _userArticleRepository.FindAll().OrderBy(m=>m.OrderArticle).ToList();
            ViewBag.ListAdv = _advertiseRepository.FindAll().OrderBy(m => m.OrderAdvertise).ToList();
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
