using System;

namespace Domain.Entities.FSYS
{
    public class LockGroupLock
    {
        public Guid LockGroupLockId { get; set; }
        public Guid LockGroupId { get; set; }
        public Guid LockId { get; set; }
    }
}
