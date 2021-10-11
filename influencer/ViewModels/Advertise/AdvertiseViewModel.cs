using influencer.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace influencer.ViewModels.Advertise
{
    public class AdvertiseViewModel : EditImageViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public Int16 Categories { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Contents { get; set; }
        [Required]
        
        [Display(Name = "Order")]
        public Int16 OrderAdvertise { get; set; }
        [Display(Name = "Followers Count")]
        public int CntFollowers { get; set; }
        [Display(Name = "Viewers Count")]
        public int CntViewers { get; set; }
        public Int16 Fame { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
    }
    public class UploadImageViewModel
    {
        [Display(Name = "Picture")]
        [DataType(DataType.Upload)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp" })]
        [FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp")]
        public IFormFile AdvPicture { get; set; }
    }
    public class EditImageViewModel : UploadImageViewModel
    {
        public int Id { get; set; }
        public string ExistingImage { get; set; }
    }
}
