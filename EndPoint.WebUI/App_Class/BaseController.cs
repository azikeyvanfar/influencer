using Data.Dapper.FORG;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EndPoint.WebUI.App_Class
{
    [CAuthorise]
    public abstract class BaseController<T> : Controller
    {
        public UserExtentionX CurrentUser;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _config;
        private readonly ILogger _logger;
        // private readonly IEmailSender _emailSender;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly UserManager<ApplicationUser> _userManager;

        protected BaseController(
            IConfiguration config,
            IHttpContextAccessor httpContextAccessor,
            //UserManager<ApplicationUser> userManager,
            //SignInManager<ApplicationUser> signInManager,
            //IEmailSender emailSender,
            ILogger<T> logger
            )
        {
            _config = config;
            _httpContextAccessor = httpContextAccessor;
            if (Authentication._UserExtentionRepos == null)
            {
                Authentication._UserExtentionRepos = new UserExtentionRepository(_config);
            }
            //_userManager = userManager;
            //_signInManager = signInManager;
            //   _emailSender = emailSender;
            _logger = logger;

            if (CurrentUser == null)
            {
                string cookie = _httpContextAccessor.HttpContext.Request.Cookies["Fanus_FMS_Cooki"];
                CurrentUser = Authentication.CurrentUser(cookie);
            }
        }
    }
}
