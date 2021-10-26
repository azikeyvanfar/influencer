using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Team
    {
        public Guid Id { get; set; }

        [StringLength(200)]
        public string HeadName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public Int16 OrderTeam { get; set; }

        public string Twitter { get; set; }
        
        public string Facebook { get; set; }
        
        public string Instagram { get; set; }
        
        public string Linkedin { get; set; }
        
        public string TeamPicture { get; set; }

        [Required]
        public int LanguageId { get; set; }
        public Languages Language { get; set; }
    }
}
