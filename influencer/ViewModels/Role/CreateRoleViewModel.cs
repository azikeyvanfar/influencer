﻿using Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace influencer.ViewModels.Role
{
    public class CreateRoleViewModel
    {
        public CreateRoleViewModel()
        {
            ActionAndControllerNames = new List<ActionAndControllerName>();
        }

        [Required()]
        [Display(Name = "نام مقام")]
        public string RoleName { get; set; }
        public IList<ActionAndControllerName> ActionAndControllerNames { get; set; }
    }

   
}
