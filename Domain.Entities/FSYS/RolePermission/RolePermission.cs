using System;

namespace Domain.Entities.FSYS
{
    public class RolePermission
    {
        public Int64 RolePermissionId { get; set; }
        public Int64 RoleId { get; set; }
        public Int64 MenuId { get; set; }
        public bool Read { get; set; }
    }
}
