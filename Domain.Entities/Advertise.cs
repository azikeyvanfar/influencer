using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Advertise
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public Int16 Categories { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name ="Name")]
        public string Title { get; set; }
        [StringLength(500)]
        public string Contents { get; set; }
        [Required]
        [Display(Name = "Picture")]
        public string AdvPicture { get; set; }
        public Int16 OrderAdvertise { get; set; }
        [Display(Name = "Followers")]
        public int CntFollowers { get; set; }
        [Display(Name = "Viewers")]
        public int CntViewers { get; set; }
        [Display(Name = "Rank")]
        public Int16 Fame { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
        [Required]
        public bool AdvConfirm { get; set; }
       
    }
}
