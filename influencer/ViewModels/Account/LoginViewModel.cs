using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace influencer.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required]
        //, Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        //, Display(Name = "رمز عبور")]
        public string Password { get; set; }

        //[Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
}
