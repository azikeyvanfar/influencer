using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.FORG
{
    //[Table("FORG.[User]")]
    public class User
    {
       // [ExplicitKey]
        public Guid UserId { get; set; }
       
        [Computed]
        [Display(Name = "نام و نام خانوادگی")]
        public string DisplayName { get; set; }
        [Required]

        [Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Display(Name = "فعال")]
        public bool IsActive { get; set; }



        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }


        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        public bool IsOnline { get; set; }
        public bool HasToken { get; set; }
        public DateTime? LastOnline { get; set; }
        [Required]
        [Computed]
        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Computed]
        public int Row { get; set; }
        [Computed]
        public int TotalCount { get; set; }
        
        [Computed]
        public DateTime LoginDateTime { get; set; }

    }
}
