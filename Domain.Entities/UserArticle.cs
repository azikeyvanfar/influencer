using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UserArticle
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public Int16 Categories { get; set; }
        [Required]
        public string Title { get; set; }
        public string Contents { get; set; }
        public Int16 OrderArticle { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateTime
        {
            get
            {
                return dateCreated.HasValue
                   ? dateCreated.Value
                   : DateTime.Now;
            }

            set { dateCreated = value; }
        }
        private DateTime? dateCreated = null;
    }
}
