using System;
using System.Collections.Generic;

namespace Domain.Contracts.Commons
{
    public interface INode
    {
        List<INode> Children { get; set; }
        Int64 MenuId { get; set; }
        string Text { get; set; }
        string Link { get; set; }
        string Icon { get; set; }
    }
}
