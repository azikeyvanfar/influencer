using Dapper.Contrib.Extensions;
using System;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.AccessRole")]
    public class AccessRole
    {
        [ExplicitKey]
        public Guid AccessRoleId { get; set; }
        public string Title { get; set; }
    }    
}