using Dapper.Contrib.Extensions;
using System;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.AccessRoleDetail")]
    public class AccessRoleDetail
    {
        [ExplicitKey]
        public Guid AccessRoleDetailId { get; set; }
        public Guid AccessRoleId { get; set; }
        public string KeyIds { get; set; }
        public string Type { get; set; }
    }    
}