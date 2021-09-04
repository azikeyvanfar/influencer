using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SiteManage
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Categories { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Contents { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }
    }
}
