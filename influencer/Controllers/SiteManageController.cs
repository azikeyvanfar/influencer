using Microsoft.AspNetCore.Mvc;
using influencer.ViewModels.SiteManage;
using Microsoft.AspNetCore.Authorization;
using influencer.Models.Context;

namespace influencer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SiteManageController : Controller
    {
        private readonly AppDbContext _context;

        public SiteManageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Manage()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<IActionResult> ManageAsync(Manage siteMange)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siteMange);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(siteMange);
        }
    }
}
