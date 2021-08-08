using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Net.Http.Headers;

namespace EndPoint.WebUI.App_Class
{
    public class Upload_JqueryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private IHostingEnvironment hostingEnv;
        public Upload_JqueryController(IHostingEnvironment env)
        {
            hostingEnv = env;
        }
        [HttpPost]
        public string Upload_File()
        {
            string result = string.Empty;
            try
            {
                long size = 0;
                Microsoft.AspNetCore.Http.IFormFileCollection file = Request.Form.Files;
                string filename = ContentDispositionHeaderValue
                                .Parse(file[0].ContentDisposition)
                                .FileName
                                .Trim('"');
                string Path = $@"\Images\Icon" + $@"\{ filename}";
                string FilePath = hostingEnv.WebRootPath + Path;
                size += file[0].Length;
                using (FileStream fs = System.IO.File.Create(FilePath))
                {
                    file[0].CopyTo(fs);
                    fs.Flush();
                }
                //result = FilePath;
                result = Path;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }        
    }
}