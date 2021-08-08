using System;

namespace Domain.Entities.FSYS
{
    public class LockNew
    {
        public Guid LockId { get; set; }
        public Guid LockCategoryId { get; set; }
        public string Title { get; set; }
        public string TagName { get; set; }
        public string Comment { get; set; }
        public Int16 DefaultMode { get; set; }
        public int ViewOrder { get; set; }
        public int LockType { get; set; }
    }
}
