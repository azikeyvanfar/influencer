using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace influencer.ViewModels.UserArticle
{
    public class UserArticleViewModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
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
        [Required]
        public string Title { get; set; }
        [Required]
        public string Contents { get; set; }
        public DateTime DateTime { get; set; }
    }
}