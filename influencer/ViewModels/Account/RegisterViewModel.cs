using influencer.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace influencer.ViewModels.Account
{
    public class RegisterViewModel: EditImageViewModel
    {
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Required")]
        [Remote("IsUserNameInUse", "Account", HttpMethod = "POST",
        AdditionalFields = "__RequestVerificationToken")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        [Remote("IsEmailInUse", "Account", HttpMethod = "POST",
          AdditionalFields = "__RequestVerificationToken")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ConfirmPassword")]
        [Required(ErrorMessage = "Required")]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "UserCategory")]
        [Required(ErrorMessage = "Required")]
        public int UserCategory { get; set; }
        
        /**Start Blogger*/
        public string Firstname { get; set; }

        public string Lastname { get; set; }
        
        public string Country{ get; set; }

        public string InstagramPage{ get; set; }
        
        public int? ApproximatePrice{ get; set; }
        
        public string YourFavourites{ get; set; }
        
        [MaxLength(11)]
        public string PhoneNumber{ get; set; }
        
        public string AnythingElse { get; set; }
        /**End Blogger*/
        /**Start Company*/
        public string CompanyName  { get; set; }

        public string Brand{ get; set; }

        //public int PhoneNumber { get; set; }
        public string ProductsServices { get; set; }

        public int? ApproximateBudget { get; set; }

        public string CountryOfOrigin { get; set; }

        public string DestinationCountries{ get; set; }

       // public string AnythingElse{ get; set; }
         /**Start Company*/
    }
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" })]
        [FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp")]
        public IFormFile YourPicture { get; set; }
    }
    public class EditImageViewModel : UploadImageViewModel
    {
        public int Id { get; set; }
        public string ExistingImage { get; set; }
    }
}
