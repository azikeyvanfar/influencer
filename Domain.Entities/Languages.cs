using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Languages
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string LanguageTitle { get; set; }


        public List<UserArticle> userArticles { get; set; }
    }
}
