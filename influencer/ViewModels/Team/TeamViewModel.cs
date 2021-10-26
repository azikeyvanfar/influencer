using influencer.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace influencer.ViewModels.Team
{
    public class TeamViewModel : EditImageViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string HeadName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Order")]
        public Int16 OrderTeam { get; set; }

        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }

    }
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" })]
        //[FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp")]
        public IFormFile TeamPicture { get; set; }
    }
    public class EditImageViewModel : UploadImageViewModel
    {
        public int? Id { get; set; }
        public string ExistingImage { get; set; }
    }
}
