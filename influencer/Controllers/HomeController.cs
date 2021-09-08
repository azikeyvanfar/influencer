using Domain.Contracts;
using Domain.Entities;
using influencer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace influencer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserArticleRepository _userArticleRepository;
        public HomeController(ILogger<HomeController> logger, IUserArticleRepository userArticleRepository)
        {
            _logger = logger;
            _userArticleRepository = userArticleRepository;
        }

        public IActionResult Index()
        {
            List<UserArticle> article = _userArticleRepository.FindAll().ToList();
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
    }
}
