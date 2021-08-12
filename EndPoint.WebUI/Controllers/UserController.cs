using Domain.Contracts;
using Domain.Contracts.FORG;
using Domain.Entities.Commons;
using Domain.Entities.FORG;
using Domain.Entities.FSYS;
using EndPoint.WebUI.App_Class;
using EndPoint.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace EndPoint.WebUI.Controllers
{
    public class UserController : BaseController<UserController>
    {
        private readonly IUserRepository _UserRepo;
      //  private readonly IUserExtentionRepository _UserExtensionRepos;
        private readonly IBasicDataRepository _BasicDataRepo;
        //public string _Password;

        public UserController(ILogger<UserController> logger, IUserRepository UserRepo, IBasicDataRepository BasicDataRepo, IConfiguration config, IHttpContextAccessor httpContextAccessor) : base(config, httpContextAccessor, logger)
        {
            _UserRepo = UserRepo;
         //   _UserExtensionRepos = UserExtensionRepos;
            _BasicDataRepo = BasicDataRepo;
        }
        public IActionResult Login(User model)
        {
            return PartialView(model);
        }
        public IActionResult UserIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserList(string filterName, int pageNumber, int pageSize, bool refresh)
        {
            if (filterName == null)
            {
                filterName = "";
            }
            List<User> people = _UserRepo.GetUser(filterName, pageNumber, pageSize);
            ViewBag.Refresh = refresh;
            return PartialView(people);
        }
        public IActionResult Add(Guid? id)
        {
            bool HasPerson;

            HasPerson = false;
            ViewBag.HasPerson = HasPerson;

            List<BasicData> listBd = _BasicDataRepo.GetBasicDataByGroupKey("LeakDetector");
            SelectList LeakDetectorList = new SelectList(listBd, "Text", "Value");
            ViewBag.LeakDetectorList = LeakDetectorList;

            return View("User");

        }
        //[HttpPost]
        //public IActionResult AddToDb(UserPerson UserPerson)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string password = ManageAccount.CalculateMD5Hash(UserPerson.User.Password);
        //        UserPerson.User.Password = password;
        //        bool resBool = true;
        //        return Json(new { success = resBool });
        //    }
        //    return RedirectToAction("Add");
        //}
        //public IActionResult Edit(Guid id)
        //{
        //    User User = _UserRepo.Fetch(id);

        //    UserPerson userPerson = new UserPerson();
        //    userPerson.User = User;
        //    userPerson.User.ConfirmPassword = userPerson.User.Password;
        //    bool HasPerson = false;
        //    ViewBag.HasPerson = HasPerson;
        //    List<BasicData> listBd = _BasicDataRepo.GetBasicDataByGroupKey("LeakDetector");
        //    SelectList LeakDetectorList = new SelectList(listBd, "Text", "Value");
        //    ViewBag.LeakDetectorList = LeakDetectorList;
        //    return View("User", userPerson);
        //}


        [HttpGet]
        public IActionResult Search(string param, int PageNumber, int PageSize)
        {
            // Guid companyId = Guid.Parse(HttpContext.Request.Cookies["CompanyId"]);
            List<User> people = _UserRepo.GetUser(param, PageNumber, PageSize);
            return View("UserIndex", people);
        }
        [HttpPost]
        public IActionResult EditToDbUser(User user)
        {
            if (ModelState.IsValid)
            {
                user.Password = ManageAccount.CalculateMD5Hash(user.Password);
                bool res = _UserRepo.Update(user);
                if (res == true)
                {
                    return Json(new { success = res });
                }
            }
            return View("UserProfile", User);
        }
        public IActionResult GetDataUsers()
        {
            List<Base> listFen = _UserRepo.GetUsers();
            return Json(listFen);
        }
        //[HttpPost]
        //public IActionResult SignOut(Guid UserId) {
        //    _UserExtensionRepos.Delete(new UserExtension() { UserId = UserId });
        //    return Json(new { success = true });
        //}
    }
}