using Domain.Contracts;
using Domain.Entities;
using influencer.Models;
using influencer.ViewModels.ContactUs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Domain.Contracts;

namespace influencer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserArticleRepository _userArticleRepository;
        private readonly IAdvertiseRepository _advertiseRepository;
        private readonly ILanguagesRepository _languagesRepository;
        private readonly ITeamRepository _TeamRepository;
        private readonly IHtmlLocalizer<HomeController> _localizer;
        private readonly IMessageSender _messageSender; 
        public HomeController(ILogger<HomeController> logger, IUserArticleRepository userArticleRepository, IAdvertiseRepository advertiseRepository, ILanguagesRepository languagesRepository, ITeamRepository TeamRepository, IHtmlLocalizer<HomeController> localizer, IMessageSender messageSender)
        {
            _logger = logger;
            _userArticleRepository = userArticleRepository;
            _advertiseRepository = advertiseRepository;
            _languagesRepository = languagesRepository;
            _TeamRepository = TeamRepository;
            _localizer = localizer;
            _messageSender = messageSender;
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

        public async Task<string> Consultation(ConsultationViewModel consultation)
        {
            string urlManageUser = _localizer["Name"].Value + " = <b>" + consultation.Name + "</b><br/> " + _localizer["Email"].Value + " = <b>" + consultation.Email + "</b><br/> " + _localizer["Favorite"].Value + " = " + consultation.Favorite;
            await _messageSender.SendEmailAsync("adsfluencermail@gmail.com", _localizer["Consultation"].Value + " with " + consultation.Name + " ( " + consultation.Email + " ) ", urlManageUser);
            return "OK";
        }
        public async Task<string> Contact(ContactViewModel contact)
        {
            string TestMarket = "";
            switch (contact.TestMarket)
            {
                case "1":
                    TestMarket = _localizer["BrandAwareness"].Value;
                    break;
                case "2":
                    TestMarket = _localizer["CustomerAcquisition"].Value;
                    break;
                case "3":
                    TestMarket = _localizer["AppInstalls"].Value;
                    break;
                case "4":
                    TestMarket = _localizer["IntroduceStartUp"].Value;
                    break;
                case "5":
                    TestMarket = _localizer["TestAdsfluencer"].Value;
                    break;
            }
            string urlManageUser = _localizer["Name"].Value + " = <b>" + contact.YourName + "</b><br/> " + _localizer["Email"].Value + " = <b>" + contact.Email + "</b><br/> " + _localizer["Company"].Value + " = " + contact.Company+ "<br/> " + _localizer["Instagram"].Value + " = " + contact.Instagram + "<br/> " + _localizer["Budget"].Value + contact.Budget + "<br/> " + _localizer["Market"].Value + " = " + TestMarket;
            await _messageSender.SendEmailAsync("adsfluencermail@gmail.com", _localizer["Contact"].Value + " with " + contact.YourName + " ( " + contact.Email + " ) ", urlManageUser);
            return "OK";
        }
    }
}
