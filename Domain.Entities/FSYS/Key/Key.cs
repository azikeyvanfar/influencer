using System;

namespace Domain.Entities.FSYS
{
    public class Key
    {
        public Guid KeyId { get; set; }
        public Guid LockId { get; set; }
        public Guid OwnerId { get; set; }
        public Int16 KeyType { get; set; }
    }
}
