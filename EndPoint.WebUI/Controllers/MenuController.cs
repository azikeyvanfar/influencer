using Domain.Contracts;
using Domain.Entities.Commons;
using Domain.Entities.FSYS;
using EndPoint.WebUI.App_Class;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace EndPoint.WebUI.Controllers
{
    public class MenuController : BaseController<MenuController>
    {
        private readonly IMenuRepository _MenuRepo;
        public MenuController(ILogger<MenuController> logger, IMenuRepository MenuRepo, IConfiguration config, IHttpContextAccessor httpContextAccessor) : base(config, httpContextAccessor, logger)
        {
            _MenuRepo = MenuRepo;
        }
        public IActionResult Index()
        {
            List<MenuGroup> menu = _MenuRepo.GetAllMenu();
            return PartialView(menu);
        }
        [HttpGet]
        public JsonResult Get()
        {
            List<Tree<Menu>> records = _MenuRepo.GetAllMenuTree();
            //List<Tree<Menu>> lst = new List<Tree<Menu>>();
            //lst.AddRange(records.Select)
            return Json(records);
        }
    }
}