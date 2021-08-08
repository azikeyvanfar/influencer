using System.Collections.Generic;
namespace Domain.Entities.Commons
{
    public interface INode
    {
        List<INode> Children { get; set; }
        long MenuId { get; set; }
        string Text { get; set; }
        string Link { get; set; }
        string Icon { get; set; }
        short? ParentId { get; set; }
        int ViewOrder { get; set; }
    }
}