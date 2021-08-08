using System.Collections.Generic;

namespace Domain.Entities.Commons
{
    public class Tree<T>
    {
        public List<Tree<T>> Children { get; set; }
        public long id { get; set; }
        public string Text { get; set; }
        public short? ParentId { get; set; }
    }
}
