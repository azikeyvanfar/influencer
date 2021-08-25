using System;
using System.Diagnostics;
using System.IO;
using EndPoint.WebUI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EndPoint.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHostingEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, IHostingEnvironment environment) {
            _logger = logger;
            _environment = environment;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        public IActionResult Manage()
        {
            return View();
        }


        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                _environment.WebRootPath, "MyImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/MyImages/"}{fileName}";


            return Json(new { uploaded = true, url });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
