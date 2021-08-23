﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.FORG
{
    //[Table("[Users]")]
    public class User
    {
        [Required]
        //[Display(Name = "نام کاربری")]
        public string UserName { get; set; }

        [Required]
        //[Display(Name = "ایمیل")]
        [EmailAddress]
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

    }
}
