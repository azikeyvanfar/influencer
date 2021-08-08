using System;

namespace Domain.Entities.FSYS
{
    public class LockGroup
    {
        public Guid LockGroupId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid CompanyId { get; set; }
    }
}
