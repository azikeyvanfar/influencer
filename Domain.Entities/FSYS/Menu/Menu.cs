using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.Menu")]
    public class Menu
    {
        [ExplicitKey]
        public long MenuId { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public int ChildCount { get; set; }
        public string ClassName { get; set; }
        public string Icon { get; set; }
        public short? ParentId { get; set; }
        public string LockTagName { get; set; }
        public int ViewOrder { get; set; }
        [Computed]
        public List<Menu> children { get; set; }
    }
}
