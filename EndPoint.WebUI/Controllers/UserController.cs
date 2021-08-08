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
using System.Linq;

namespace EndPoint.WebUI.Controllers
{
    public class UserController : BaseController<UserController>
    {
        private readonly IUserRepository _UserRepo;
        private readonly IUserExtentionRepository _UserExtensionRepos;
        private readonly IBasicDataRepository _BasicDataRepo;
        //public string _Password;

        public UserController(ILogger<UserController> logger, IUserRepository UserRepo, IBasicDataRepository BasicDataRepo, IConfiguration config, IHttpContextAccessor httpContextAccessor, IUserExtentionRepository UserExtensionRepos) : base(config, httpContextAccessor, logger)
        {
            _UserRepo = UserRepo;
            _UserExtensionRepos = UserExtensionRepos;
            _BasicDataRepo = BasicDataRepo;            
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

            //if (id != null)
            //{
            //    Person person = _PersonRepo.Find(id);

            //    UserPerson userPerson = new UserPerson();
            //    userPerson.Person = person;
            //    userPerson.PersonId = person.PersonId;
            //    userPerson.HasPerson = true;

            //    HasPerson = true;
            //    ViewBag.HasPerson = HasPerson;

            //    return View("User", userPerson);
            //}

            HasPerson = false;
            ViewBag.HasPerson = HasPerson;

            List<BasicData> listBd = _BasicDataRepo.GetBasicDataByGroupKey("LeakDetector");
            SelectList LeakDetectorList = new SelectList(listBd, "Text", "Value");
            ViewBag.LeakDetectorList = LeakDetectorList;

            //List<Role> list = _RoleRepo.GetAll();
            ////SelectList listRole = new SelectList(list, "Text", "Value");
            //ViewBag.listRole = list;

            //int listRoleCount = list.Count;
            //ViewBag.listRoleCount = listRoleCount;

            return View("User");
            
        }
        [HttpPost]
        public IActionResult AddToDb(UserPerson UserPerson)
        {
            if (ModelState.IsValid)
            {
                string password = ManageAccount.CalculateMD5Hash(UserPerson.User.Password);
                UserPerson.User.Password = password;
                long res1;

                //if (UserPerson.HasPerson)
                //{
                //    bool result = _PersonRepo.Update(UserPerson.Person);
                //    res1 = result ? 0 : 1;
                //}
                //else
                //{
                //    res1 = _PersonRepo.Insert(UserPerson.Person);

                //}
                long res2 = _UserRepo.Insert(UserPerson.User);

                long res3;
                int RoleIdCount = UserPerson.RoleIds.Substring(1).Split(",").Count();
                List<string> RoleIdList = UserPerson.RoleIds.Split(",").ToList();
                //for (int i = 0; i < RoleIdCount; i++)
                //{
                //    //PersonRole personRole = new PersonRole();
                //    //personRole.PersonRoleId = Guid.NewGuid();
                //    //personRole.PersonId = UserPerson.PersonId;
                //    //personRole.RoleId = Guid.Parse(RoleIdList[i]);
                //    //res3 = _PersonRoleRepo.Insert(personRole);
                //}

                bool resBool=true;
                //if (res1 == 0 && res2 == 0/* && res3 == 0*/)
                //{
                //    resBool = true;
                //}
                //else
                //{
                //    resBool = false;
                //}
                return Json(new { success = resBool });
            }
            return RedirectToAction("Add");
        }
        public IActionResult Edit(Guid id)
        {
            User User = _UserRepo.Fetch(id);
            //_Password = User.Password;
            //Person person = _PersonRepo.Fetch(User.PersonId);
            //List<Guid> personRoleList = _PersonRoleRepo.PersonRoleList(User.PersonId);

            UserPerson userPerson = new UserPerson();
            userPerson.User = User;
            //userPerson.Person = person;
            userPerson.PersonId = User.PersonId;
            userPerson.User.ConfirmPassword = userPerson.User.Password;
            bool HasPerson = false;
            ViewBag.HasPerson = HasPerson;
            List<BasicData> listBd = _BasicDataRepo.GetBasicDataByGroupKey("LeakDetector");
            SelectList LeakDetectorList = new SelectList(listBd, "Text", "Value");
            ViewBag.LeakDetectorList = LeakDetectorList;

            //List<Role> list = _RoleRepo.GetAll();
            //ViewBag.listRole = list;

            //int listRoleCount = list.Count;
            //ViewBag.listRoleCount = listRoleCount;

            //ViewBag.personRoleList = personRoleList;

            return View("User", userPerson);
        }

        [HttpPost]
        //public IActionResult EditToDb(UserPerson UserPerson)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //bool res1 = _PersonRepo.Update(UserPerson.Person);

        //        bool res2;

        //        User User = _UserRepo.Fetch(UserPerson.User.UserId);
        //        string lastPassword = User.Password;

        //        if (UserPerson.User.Password != lastPassword)
        //        {
        //            string password = ManageAccount.CalculateMD5Hash(UserPerson.User.Password);
        //            UserPerson.User.Password = password;
        //        }
        //        res2 = _UserRepo.Update(UserPerson.User);

        //        _PersonRoleRepo.DeleteAllRolsByPersonId(UserPerson.Person.PersonId);

        //        int RoleIdCount = UserPerson.RoleIds.Substring(1).Split(",").Count();
        //        List<string> RoleIdList = UserPerson.RoleIds.Split(",").ToList();
        //        for (int i = 0; i < RoleIdCount; i++)
        //        {
        //            PersonRole personRole = new PersonRole();
        //            personRole.PersonRoleId = Guid.NewGuid();
        //            personRole.PersonId = UserPerson.PersonId;
        //            personRole.RoleId = Guid.Parse(RoleIdList[i]);
        //            long res4 = _PersonRoleRepo.Insert(personRole);
        //        }
        //        if (res1 == true && res2 == true)
        //        {
        //            return Json(new { success = res1 });
        //        }
        //    }

        //    return View("User", User);

        //}
        //public IActionResult Delete(Guid id)
        //{
        //    User User = _UserRepo.Fetch(id);

        //    _UserRepo.Delete(new User() { UserId = id });
        //    _PersonRepo.Delete(new Person() { PersonId = User.PersonId });

        //    return Json(new { success = true });
        //}

        [HttpGet]
        public IActionResult Search(string param, int PageNumber, int PageSize)
        {
            // Guid companyId = Guid.Parse(HttpContext.Request.Cookies["CompanyId"]);
            List<User> people = _UserRepo.GetUser(param, PageNumber, PageSize);
            return View("UserIndex", people);
        }
        //public IActionResult UserProfile()
        //{
        //    Guid token = Guid.Parse(HttpContext.Request.Cookies["GTC_Cooki"]);
        //    Guid userid = _UserExtensionRepos.GetUserExtensionToken(token).UserId;
        //    User user = _UserRepo.Fetch(userid);
        //    return View(user);
        //}
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