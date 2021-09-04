using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace influencer.ViewModels.SiteManage
{
    public class Manage
    {
        public IEnumerable<SelectListItem> Categories
        {
            get
            {
                return new[]
                   {
                    new SelectListItem { Value = "1", Text = "Strategy" },
                    new SelectListItem { Value = "2", Text = "Technology" },
                    new SelectListItem { Value = "3", Text = "Test" },
                };
            }
        }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime DateTime { get; set; }
    }
}