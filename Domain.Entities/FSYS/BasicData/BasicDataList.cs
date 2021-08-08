using System;

namespace Domain.Entities.FSYS
{
    public class BasicDataList
    {
        public Guid BasicDataId { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public int ViewOrder { get; set; }
        public string GroupKey { get; set; }
        public bool Editable { get; set; }
        public Guid? CompanyId { get; set; }
        public string Code { get; set; }
        public int Rows { get; set; }
        public String CompanyName { get; set; }
        public int TotalCount { get; set; }
    }
}
