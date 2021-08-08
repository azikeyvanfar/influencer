using System.Collections.Generic;

namespace Domain.Entities.FSYS
{
    public class MenuGroup
    {
        public List<Menu> Children { get; set; }
        public long MenuId { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
