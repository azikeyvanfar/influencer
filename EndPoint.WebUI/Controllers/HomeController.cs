//using EndPoint.WebUI.App_Class;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Logging;

//namespace EndPoint.WebUI.Controllers
//{
//    public class HomeController : BaseController<HomeController>
//    {
//        public HomeController(ILogger<HomeController> logger, IConfiguration config, IHttpContextAccessor httpContextAccessor) : base(config, httpContextAccessor, logger)
//        {
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }
//        public IActionResult Privacy()
//        {
//            return View();
//        }
//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View();
//        }
//    }
//}
using EndPoint.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EndPoint.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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