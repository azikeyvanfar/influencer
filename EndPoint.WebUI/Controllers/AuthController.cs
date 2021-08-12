using System;
using System.Threading.Tasks;
using EndPoint.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Vereyon.Web;

namespace EndPoint.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        IFlashMessage _flashMessage;

        public AuthController(UserManager<ApplicationUser> userManager, IFlashMessage flashMessage)
        {
            _userManager = userManager;
            _flashMessage = flashMessage;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            ViewBag.ErrorMessage = null;
            return View(new RegisterUser());
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterUser user)
        {
            try
            {
                if (string.IsNullOrEmpty(user.Username))
                    throw new Exception("The username cannot be empty!");

                if (string.IsNullOrEmpty(user.Password))
                    throw new Exception("The password cannot be empty!");

                if (user.Password != user.ConfirmPassword)
                    throw new Exception("The Passwords do not match!");

                var theUser = new ApplicationUser()
                {
                    UserName = user.Username
                };

                await _userManager.CreateAsync(theUser, user.Password);

                return View(new RegisterUser());
            }
            catch (Exception ex)
            {
                _flashMessage.Danger(ex.Message);
                return View(user);
            }
        }
    }
}