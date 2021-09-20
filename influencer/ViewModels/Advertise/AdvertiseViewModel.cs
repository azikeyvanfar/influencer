using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace influencer.ViewModels.Advertise
{
    public class AdvertiseViewModel
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
        public IFormFile AdvPicture { get; set; }
        public Int16 OrderAdvertise { get; set; }
        public int CntFollowers { get; set; }
        public int CntViewers { get; set; }
        public Int16 Fame { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
    }
}
