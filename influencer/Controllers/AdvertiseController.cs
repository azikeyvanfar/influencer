using Domain.Contracts;
using Domain.Entities;
using Domain.Entities.Context;
using influencer.Common;
using influencer.ViewModels.Advertise;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace influencer.Controllers
{
    [Authorize(Roles = "Blogger")]
    public class AdvertiseController : Controller
    {
        private readonly IAdvertiseRepository _advertiseRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AdvertiseController(IAdvertiseRepository advertiseRepository, UserManager<ApplicationUser> userManager, IWebHostEnvironment webHostEnvironment)
        {
            _advertiseRepository = advertiseRepository;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }
        /************************************************************************************/
        ////Display all Advertises
        //Method to display all Advertises which is received from 'GetAllAdvertises' method

        public IActionResult Index()
        {
            try
            {
                string loggedInUserId = _userManager.GetUserId(User);
                List<Advertise> Advertise = _advertiseRepository.FindByCondition(m => m.UserId == loggedInUserId).OrderBy(m => m.OrderAdvertise).ToList();
                return View(Advertise);
            }
            catch (Exception e)
            {
                return View();
            }
        }
        /************************************************************************************/
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertise = await _advertiseRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            if (advertise == null)
            {
                return NotFound();
            }

            return View(advertise);
        }

        // GET: advertise/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: advertise/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdvertiseViewModel advertise)
        {
            if (ModelState.IsValid)
            {
                Advertise advertise1 = new Advertise
                {
                    DateTime = DateTime.Now,
                    AdvPicture = UploadedFile(advertise),
                    UserId = _userManager.GetUserId(User),
                    Title = advertise.Title,
                    Categories = advertise.Categories,
                    Contents = advertise.Contents,
                    CntFollowers = advertise.CntFollowers,
                    CntViewers = advertise.CntViewers,
                    Fame = advertise.Fame,
                    OrderAdvertise = advertise.OrderAdvertise
                };
                await _advertiseRepository.Create(advertise1);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string UploadedFile(AdvertiseViewModel advertise)
        {
            string uniqueFileName = null;

            if (advertise.AdvPicture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + advertise.AdvPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                
                IFormFile file = advertise.AdvPicture;
                var image = Image.FromStream(file.OpenReadStream());
                var resized = new Bitmap(image, new Size(800, 600));
                using var imageStream = new MemoryStream();
                resized.Save(imageStream, ImageFormat.Jpeg);
                var imageBytes = imageStream.ToArray();
                using (var stream = new FileStream(filePath , FileMode.Create, FileAccess.Write, FileShare.Write, 4096))
                {
                    stream.Write(imageBytes, 0, imageBytes.Length);
                }

                //using (var fileStream = new FileStream(filePath, FileMode.Create))
                //{
                //    advertise.AdvPicture.CopyTo(fileStream);
                //}
            }
            return uniqueFileName;
        }

        // GET: advertise/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var advertise = await _advertiseRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            var advertiseViewModel = new AdvertiseViewModel()
            {
                Id = advertise.Id,
                Title = advertise.Title,
                Contents = advertise.Contents,
                Categories = advertise.Categories,
                CntFollowers = advertise.CntFollowers,
                CntViewers = advertise.CntViewers,
                DateTime = advertise.DateTime,
                Fame = advertise.Fame,
                OrderAdvertise = advertise.OrderAdvertise,
                ExistingImage = advertise.AdvPicture
            };
            
            if (advertise == null)
            {
                return NotFound();
            }
            return View(advertiseViewModel);
        }

        // POST: advertise/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[ValidateAntiForgeryToken]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, AdvertiseViewModel advertise)
        {
            if (id != advertise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var adv = await _advertiseRepository.FindByCondition(m=>m.Id == advertise.Id).FirstOrDefaultAsync();
                adv.Title = advertise.Title;
                adv.Contents = advertise.Contents;
                adv.Categories = advertise.Categories;
                adv.CntFollowers = advertise.CntFollowers;
                adv.CntViewers = advertise.CntViewers;
                //adv.DateTime = advertise.DateTime;
                adv.Fame = advertise.Fame;
                adv.OrderAdvertise = advertise.OrderAdvertise;
                if (advertise.AdvPicture != null)
                {
                    if (advertise.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", advertise.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    adv.AdvPicture = UploadedFile(advertise);
                }
                await _advertiseRepository.Update(adv);
                return RedirectToAction(nameof(Index));
            }
            return View(advertise);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var advertise = await _advertiseRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            var CurrentImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Uploads", advertise.AdvPicture);
            Advertise DelAdv = await _advertiseRepository.Delete(advertise);
            //if (DelAdv.Equals==null)
            //{
                if (System.IO.File.Exists(CurrentImage))
                {
                    System.IO.File.Delete(CurrentImage);
                }
            //}
            return Json(true);
        }

        private bool advertiseExists(Guid id)
        {
            return _advertiseRepository.FindByCondition(e => e.Id == id).Any();
        }
    }
}
