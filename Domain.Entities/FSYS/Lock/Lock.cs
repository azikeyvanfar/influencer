using System;

namespace Domain.Entities.FSYS
{
    public class Lock
    {
        public Guid LockId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public Int16 DefaultMode { get; set; }
    }
}
