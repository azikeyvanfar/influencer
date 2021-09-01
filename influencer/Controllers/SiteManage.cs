using Microsoft.AspNetCore.Mvc;

namespace influencer.Controllers
{
    public class SiteManage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Manage()
        {
            return View();
        }
    }
}
