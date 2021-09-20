using Domain.Contracts;
using Domain.Entities;
using Domain.Entities.Context;
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
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
            uniqueFileName = Guid.NewGuid().ToString() + "_" + advertise.AdvPicture.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                advertise.AdvPicture.CopyTo(fileStream);
            }
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
        if (advertise == null)
        {
            return NotFound();
        }
        return View(advertise);
    }

    // POST: advertise/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //[ValidateAntiForgeryToken]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, Advertise advertise)
    {
        if (id != advertise.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                await _advertiseRepository.Update(advertise);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!advertiseExists(advertise.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(advertise);
    }

    // GET: advertise/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
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

    // POST: advertise/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var advertise = await _advertiseRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
        await _advertiseRepository.Delete(advertise);
        return RedirectToAction(nameof(Index));
    }

    private bool advertiseExists(Guid id)
    {
        return _advertiseRepository.FindByCondition(e => e.Id == id).Any();
    }
}
}
