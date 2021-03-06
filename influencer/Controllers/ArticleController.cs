using Domain.Contracts;
using Domain.Entities;
using Domain.Entities.Context;
using influencer.Common;
using influencer.ViewModels.Team;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace influencer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ArticleController : Controller
    {
        private readonly IUserArticleRepository _userArticleRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ArticleController(IUserArticleRepository userArticleRepository, UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _userArticleRepository = userArticleRepository;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }
        /************************************************************************************/
        ////Display all articles
        //Method to display all articles which is received from 'GetAllArticles' method

        public IActionResult Index()
        {
            string lang = CultureInfo.CurrentCulture.Name;
            List<UserArticle> article = _userArticleRepository.FindByCondition(m => m.Language.LanguageTitle == lang).OrderBy(m => m.OrderArticle).ToList();
            List<short> ord = article.Select(m => m.OrderArticle).ToList();
            ViewBag.minOrd = ord.Min();
            ViewBag.maxOrd = ord.Max();
            return View(article);
        }
        /************************************************************************************/
        [HttpPost]
        public async Task<IActionResult> WriteArticle(UserArticle article)
        {
            if (ModelState.IsValid)
            {

                string loggedInUserId = _userManager.GetUserId(User);
                article.UserId = loggedInUserId;
                UserArticle userArticle;
                if (!article.Id.Equals(Guid.Empty))
                    userArticle = await _userArticleRepository.Update(article);
                else
                {
                    article.Contents = "<div class=\"editable\">" + article.Contents + "</div>";
                    userArticle = await _userArticleRepository.Create(article);
                }
                //if (userArticle.Id.Equals(Guid.Empty))
                    return RedirectToAction("Index");
                //else
                //    return View(article);
            }
            return View(article);
        }
        [HttpGet]
        public ActionResult<UserArticle> WriteArticle(Int16? order,Guid? id)
        {
            if (id == null)
            {
                if (order == null)
                {
                    ViewBag.order = _userArticleRepository.FindAll().OrderByDescending(m => m.OrderArticle).Select(m => m.OrderArticle).FirstOrDefault();
                }
                else
                {
                    ViewBag.order = order;
                }
                return View(new UserArticle());
            }
            else
            {
                UserArticle article = _userArticleRepository.FindByCondition(m => m.Id == id).FirstOrDefault();
                return View(article);
            }
        }
       
         /************************************************************************************/
        ////Display single article
        //Method to view a single article on SingleArticleView
        public IActionResult SingleArticle(Guid id)
        {
            var article = _userArticleRepository.FindByCondition(m => m.Id == id).FirstOrDefault();

            return View(article);
        }


        /************************************************************************************/
        ////Delete article
        //Method called by the view to delete the Article
        public async Task<IActionResult> RemoveArticle(Guid id)
        {
            UserArticle article = _userArticleRepository.FindByCondition(m => m.Id == id).FirstOrDefault();
            await _userArticleRepository.Delete(article);
            return Json(true);
        }
        [HttpPost]
        public async Task<IActionResult> Update(string content,Guid id)
        {
            if (!content.Equals(null)) {
                var result = JsonConvert.DeserializeObject(content);
                UserArticle article = _userArticleRepository.FindByCondition(m => m.Id == id).FirstOrDefault();
                article.Contents = result.ToString();
                await _userArticleRepository.Update(article);
                //IEnumerable<UserArticle> articles= JsonConvert.DeserializeObject<IEnumerable<UserArticle>>(data);
                //foreach (UserArticle art in articles)
                //{
                //    _userArticleRepository.Update(art);
                //}
                return Json(true);
            }
            return Json(false);
        }
        [HttpGet]
        public async Task<IActionResult> UpOrder(Guid id) {
            UserArticle article = _userArticleRepository.FindByCondition(m => m.Id == id).FirstOrDefault();
            article.OrderArticle = Convert.ToInt16(article.OrderArticle-1);
            UserArticle article1 = _userArticleRepository.FindByCondition(m => m.OrderArticle == article.OrderArticle).FirstOrDefault();
            await _userArticleRepository.Update(article);
            article1.OrderArticle = Convert.ToInt16(article1.OrderArticle+1);
            await _userArticleRepository.Update(article1);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> DownOrder(Guid id)
        {
            UserArticle article = _userArticleRepository.FindByCondition(m => m.Id == id).FirstOrDefault();
            article.OrderArticle = Convert.ToInt16(article.OrderArticle + 1);
            UserArticle article1 = _userArticleRepository.FindByCondition(m => m.OrderArticle == article.OrderArticle).FirstOrDefault();
            await _userArticleRepository.Update(article);
            article1.OrderArticle = Convert.ToInt16(article1.OrderArticle - 1);
            await _userArticleRepository.Update(article1);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public string UploadedFile(IFormFile picture,int number)
        {
            string uniqueFileName = null;

            if (picture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Tabs");
                uniqueFileName = "tabs-" + number+"-"+picture.FileName+".jpg";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                IFormFile file = picture;
                var image = Image.FromStream(file.OpenReadStream());
                image = FixedSizeImage.FixedSize(image, 800, 600);
                using var imageStream = new MemoryStream();
                image.Save(imageStream, ImageFormat.Jpeg);
                var imageBytes = imageStream.ToArray();
                using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write, 4096))
                {
                    stream.Write(imageBytes, 0, imageBytes.Length);
                }
            }
            return uniqueFileName;
        }
        
        //public ActionResult UploadImage(HttpPostedFileBase upload, string CKEditorFuncNum, string CKEditor,
        //   string langCode)
        //{
        //    string vImagePath = String.Empty;
        //    string vMessage = String.Empty;
        //    string vFilePath = String.Empty;
        //    string vOutput = String.Empty;
        //    try
        //    {
        //        if (upload != null && upload.ContentLength > 0)
        //        {
        //            var vFileName = DateTime.Now.ToString("yyyyMMdd-HHMMssff") +
        //                            Path.GetExtension(upload.FileName).ToLower();
        //            var vFolderPath = Server.MapPath("/Upload/");
        //            if (!Directory.Exists(vFolderPath))
        //            {
        //                Directory.CreateDirectory(vFolderPath);
        //            }
        //            vFilePath = Path.Combine(vFolderPath, vFileName);
        //            upload.SaveAs(vFilePath);
        //            vImagePath = Url.Content("/Upload/" + vFileName);
        //            vMessage = "تصویر با موفقیت ذخیره شد";
        //        }
        //    }
        //    catch
        //    {
        //        vMessage = "There was an issue uploading";
        //    }
        //    vOutput = @"<html><body><script>window.parent.CKEDITOR.tools.callFunction(" + CKEditorFuncNum + ", \"" + vImagePath + "\", \"" + vMessage + "\");</script></body></html>";
        //    return Content(vOutput);
        //}
    }
}
