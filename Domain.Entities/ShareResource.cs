using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ShareResource
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string LanguageTitle { get; set; }
        
    }
}
