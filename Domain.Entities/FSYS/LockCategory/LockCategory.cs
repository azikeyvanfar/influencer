using System;

namespace Domain.Entities.FSYS
{
    public class LockCategory
    {
        public Guid LockCategoryId { get; set; }
        public string Title { get; set; }
        public int ViewOrder { get; set; }
        public Guid MasterLockCategoryId { get; set; }
    }
}
