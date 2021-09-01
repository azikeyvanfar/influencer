using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace influencer.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        //[Display(Name = "نام کاربری")]
        [Remote("IsUserNameInUse", "Account", HttpMethod = "POST",
        AdditionalFields = "__RequestVerificationToken")]
        public string UserName { get; set; }

        [Required]
        //[Display(Name = "ایمیل")]
        [EmailAddress]
        [Remote("IsEmailInUse", "Account", HttpMethod = "POST",
          AdditionalFields = "__RequestVerificationToken")]
        public string Email { get; set; }

        [Required]
        //[Display(Name = "رمزعبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        //[Display(Name = "تکرار رمزعبور")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        
        //[Display(Name = "تکرار رمزعبور")]
        public string City { get; set; }

        [Required]
        //[Display(Name = "تکرار رمزعبور")]
        public int UserCategory { get; set; }
    }
}
