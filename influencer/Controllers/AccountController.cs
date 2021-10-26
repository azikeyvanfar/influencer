using CountryData.Standard;
using Domain.Contracts;
using Domain.Entities.Context;
using influencer.Common;
using influencer.ViewModels.Account;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace influencer.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMessageSender _messageSender;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHtmlLocalizer<AccountController> _localizer;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, IMessageSender messageSender, IWebHostEnvironment webHostEnvironment, IHtmlLocalizer<AccountController> localizer)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _messageSender = messageSender;
            _webHostEnvironment = webHostEnvironment;
            _localizer = localizer;
        }

        public async Task<IActionResult> Index()
        {
            if (!_signInManager.IsSignedIn(User))
                return RedirectToAction("Login", "Home",new{ returnUrl = Url.Action("Index")});
            ApplicationUser user = await _userManager.GetUserAsync(User);
            return View(user);
        }
        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.countries = GetCountry();
            return View();
        }
        public IEnumerable<Country> GetCountry()
        {
            var helper = new CountryHelper();
            IEnumerable<Country> countries = helper.GetCountryData();
            return countries;
        }
        [HttpPost]
        public List<Regions> GetRegions(string Country)
        {
            var helper = new CountryHelper();
            List<Regions> regions = helper.GetRegionByCountryCode(Country).ToList();
            return regions;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    City = model.City,
                    UserCategory = model.UserCategory,
                    Firstname = model.Firstname,
                    Lastname = model.Lastname,
                    Country = model.Country,
                    InstagramPage = model.InstagramPage,
                    YourFavourites = model.YourFavourites,
                    AnythingElse = model.AnythingElse,
                    YourPicture = UploadedFile(model),
                    CompanyName = model.CompanyName,
                    Brand = model.Brand,
                    ProductsServices = model.ProductsServices,
                    CountryOfOrigin = model.CountryOfOrigin,
                    DestinationCountries = model.DestinationCountries,
                    ApproximatePrice = model.ApproximatePrice,
                    ApproximateBudget = model.ApproximateBudget,
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    string userAdd = "";
                    switch (model.UserCategory)
                    {
                        case 3:
                            List<string> requestRoles = new List<string>() { "Admin" };
                            await _userManager.AddToRolesAsync(user, requestRoles);
                            userAdd = "Admin";
                            break;
                        case 2:
                            userAdd = "Blogger";
                            break;
                        case 1:
                            userAdd = "Company";
                            break;
                        default:
                            userAdd = "Admin";
                            break;
                    }
                    var emailConfirmationToken =
                        await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var emailMessage = "<b>Adsfluencer.</b><hr/><br/>"+_localizer["Confirm"].Value +"<br/>"+_localizer["YourEmail"].Value + "<br /><a href='" +
                        Url.Action("ConfirmEmail", "Account",new { username = user.UserName, token = emailConfirmationToken },Request.Scheme)+"'>"+_localizer["ClickThis"].Value + "</a>";
                    await _messageSender.SendEmailAsync(model.Email, _localizer["Confirm"].Value, emailMessage);
                    /*Email Manager Site*/
                    string urluser = $"{Request.Scheme}://{Request.Host}" + "/ManageUser/Index";
                    string urlManageUser = _localizer["UserName"].Value + " = <b>"+user.UserName + "</b> <br/> "+_localizer["Email"].Value + "=<b>"+ user.Email + "</b><br/> "+_localizer["Created"].Value + "<hr/><br/><a href='" + urluser + "'>"+_localizer["ActiveUser"].Value + "</a>";
                    await _messageSender.SendEmailAsync("adsfluencermail@gmail.com", _localizer["NewUser"].Value + " " + userAdd + " "+_localizer["Add"].Value, urlManageUser);

                    return RedirectToAction("Index", "Home", new { alertSuccess = HttpUtility.UrlDecode(_localizer["Confirm"].Value + " " + _localizer["GoYourEmail"].Value) });
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Home");

            var model = new LoginViewModel()
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            ViewData["returnUrl"] = returnUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Home");

            model.ReturnUrl = returnUrl;
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ViewData["returnUrl"] = returnUrl;

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, true);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return RedirectToAction("Index", "Home");
                }

                if (result.IsLockedOut)
                {
                    ViewData["ErrorMessage"] = "Your account has been locked for five minutes due to five failed logins";
                    return View(model);
                }

                ModelState.AddModelError("", "UserName Or Password Is Not Correct!");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut()
        {
            // HttpContext.Response.Cookies.Delete("RVG");
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) return Json(true);
            return Json("The entered email is already exist");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IsUserNameInUse(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return Json(true);
            return Json("The entered username is already exist");
        }


        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userName, string token)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(token))
                return NotFound();
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null) return NotFound();
            var result = await _userManager.ConfirmEmailAsync(user, token);

            // return Content(result.Succeeded ? "Email Confirmed" : "Email Not Confirmed");
            Content(result.Succeeded ? "Email Confirmed" : "Email Not Confirmed");
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallBack", "Account",
                new { ReturnUrl = returnUrl });

            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> ExternalLoginCallBack(string returnUrl = null, string remoteError = null)
        {
            returnUrl =
                (returnUrl != null && Url.IsLocalUrl(returnUrl)) ? returnUrl : Url.Content("~/");

            var loginViewModel = new LoginViewModel()
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            {
                ModelState.AddModelError("", $"Error : {remoteError}");
                return View("Login", loginViewModel);
            }

            var externalLoginInfo = await _signInManager.GetExternalLoginInfoAsync();
            if (externalLoginInfo == null)
            {
                ModelState.AddModelError("ErrorLoadingExternalLoginInfo", $"Problem!");
                return View("Login", loginViewModel);
            }

            var signInResult = await _signInManager.ExternalLoginSignInAsync(externalLoginInfo.LoginProvider,
                externalLoginInfo.ProviderKey, false, true);

            if (signInResult.Succeeded)
            {
                return Redirect(returnUrl);
            }

            var email = externalLoginInfo.Principal.FindFirstValue(ClaimTypes.Email);

            if (email != null)
            {
                var user = await _userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    var userName = email.Split('@')[0].Split('.')[0];
                    user = new ApplicationUser()
                    {
                        UserName = (userName.Length <= 10 ? userName : userName.Substring(0, 10)),
                        Email = email,
                        EmailConfirmed = true,
                        City = "Tehran",
                        Firstname = "",
                        Lastname = "",
                        Country = "",
                        InstagramPage = "",
                        YourFavourites = "",
                        AnythingElse = "",
                        YourPicture = "",
                        CompanyName = "",
                        Brand = "",
                        ProductsServices = "",
                        CountryOfOrigin = "",
                        DestinationCountries = "",
                        ApproximatePrice = 0,
                        ApproximateBudget = 0,
                    };

                    await _userManager.CreateAsync(user);
                }

                await _userManager.AddLoginAsync(user, externalLoginInfo);
                await _signInManager.SignInAsync(user, false);

                return Redirect(returnUrl);
            }

            ViewBag.ErrorTitle = "Please contact support";
            ViewBag.ErrorMessage = $"{externalLoginInfo.LoginProvider} Can not get information from";
            return View();
        }
        private string UploadedFile(RegisterViewModel register)
        {
            string uniqueFileName = null;

            if (register.YourPicture != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads/Account");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + register.YourPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                IFormFile file = register.YourPicture;
                var image = Image.FromStream(file.OpenReadStream());
                image = FixedSizeImage.FixedSize(image, 500, 400);
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
    }
}