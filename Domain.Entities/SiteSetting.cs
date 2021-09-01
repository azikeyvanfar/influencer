using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class SiteSetting
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime? LastTimeChanged { get; set; }
    }
}
