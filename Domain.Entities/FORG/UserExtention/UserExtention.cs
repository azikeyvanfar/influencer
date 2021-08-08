using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Domain.Entities.FORG
{
    [Table("FORG.UserExtention")]
    public class UserExtention
    {
        [ExplicitKey]
        public Guid UserId { get; set; }

        public Guid? Token { get; set; }
        [DisplayName("برچسب")]
        public string TagName { get; set; }
        [DisplayName("نام")]
        public string DisplayName { get; set; }
        [DisplayName("نقش")]
        public string Roles { get; set; }
        [DisplayName("جزئیات اضافی")]
        public string ExtensionDetail { get; set; }
    }
}
