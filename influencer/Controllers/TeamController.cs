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
using Microsoft.EntityFrameworkCore;
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
    public class TeamController : Controller
    {
        private readonly ITeamRepository _TeamRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILanguagesRepository _languagesRepository;
        public TeamController(ITeamRepository TeamRepository, IWebHostEnvironment webHostEnvironment, ILanguagesRepository languagesRepository)
        {
            _TeamRepository = TeamRepository;
            _webHostEnvironment = webHostEnvironment;
            _languagesRepository = languagesRepository;
        }
        /************************************************************************************/
        ////Display all Teams
        //Method to display all Teams which is received from 'GetAllTeams' method

        public IActionResult Index()
        {
            string lang = CultureInfo.CurrentCulture.Name;
            try
            {
                List<Team> Team = _TeamRepository.FindByCondition(m => m.Language.LanguageTitle == lang).OrderBy(m => m.OrderTeam).ToList();
                return View(Team);
            }
            catch (Exception e)
            {
                return View();
            }
        }
        // GET: Team/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamViewModel Team)
        {
            if (ModelState.IsValid)
            {
                Guid Id = Guid.NewGuid();
                Team Team1 = new Team
                {
                    Id = Id,
                    TeamPicture = UploadedPic(Team, Id),
                    HeadName = Team.HeadName,
                    Description = Team.Description,
                    Facebook = Team.Facebook,
                    Instagram = Team.Instagram,
                    Linkedin = Team.Linkedin,
                    Twitter = Team.Twitter,
                    OrderTeam = Team.OrderTeam,
                    LanguageId = _languagesRepository.FindByCondition(m => m.LanguageTitle == CultureInfo.CurrentCulture.Name).Select(m=>m.Id).FirstOrDefault()
                };
                await _TeamRepository.Create(Team1);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
       private string UploadedPic(TeamViewModel Team, Guid Id)
        {
            string uniqueFileName = null;

            if (Team.TeamPicture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Team");
                uniqueFileName = Id.ToString() + "_team.jpeg" ;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                IFormFile file = Team.TeamPicture;
                var image = Image.FromStream(file.OpenReadStream());
                image = FixedSizeImage.FixedSize(image, 600, 600);
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

        // GET: Team/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Team = await _TeamRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            var TeamViewModel = new TeamViewModel()
            {
                Id = Team.Id,
                HeadName = Team.HeadName,
                Description = Team.Description,
                Facebook = Team.Facebook,
                Instagram = Team.Instagram,
                Linkedin = Team.Linkedin,
                Twitter = Team.Twitter,
                OrderTeam = Team.OrderTeam,
                ExistingImage = Team.TeamPicture
            };

            if (Team == null)
            {
                return NotFound();
            }
            return View(TeamViewModel);
        }

        // POST: Team/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[ValidateAntiForgeryToken]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, TeamViewModel Team)
        {
            if (id != Team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var teamGet = await _TeamRepository.FindByCondition(m => m.Id == Team.Id).FirstOrDefaultAsync();
                teamGet.Id = Team.Id;
                teamGet.HeadName = Team.HeadName;
                teamGet.Description = Team.Description;
                teamGet.Facebook = Team.Facebook;
                teamGet.Instagram = Team.Instagram;
                teamGet.Linkedin = Team.Linkedin;
                teamGet.Twitter = Team.Twitter;
                teamGet.OrderTeam = Team.OrderTeam;
                if (Team.TeamPicture != null)
                {
                    if (Team.ExistingImage != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Team", Team.ExistingImage);
                        System.IO.File.Delete(filePath);
                    }

                    teamGet.TeamPicture = UploadedPic(Team, teamGet.Id);
                }
                await _TeamRepository.Update(teamGet);
                return RedirectToAction(nameof(Index));
            }
            return View(Team);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var Team = await _TeamRepository.FindByCondition(m => m.Id == id).FirstOrDefaultAsync();
            var CurrentImage = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Uploads\\Team", Team.TeamPicture);
            Team DelAdv = await _TeamRepository.Delete(Team);
            if (System.IO.File.Exists(CurrentImage))
            {
                System.IO.File.Delete(CurrentImage);
            }
            //}
            return Json(true);
        }

        private bool TeamExists(Guid id)
        {
            return _TeamRepository.FindByCondition(e => e.Id == id).Any();
        }
    }
}
