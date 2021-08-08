using Dapper.Contrib.Extensions;
using System;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.Permission")]
    public class Permission
    {
        [ExplicitKey]
        public Guid PermissionId { get; set; }
        public Guid OwnerId { get; set; }
        public Int16 OwnerType { get; set; }
        public string KeyIds { get; set; }
        public Int16 KeyType { get; set; }
    }
}
