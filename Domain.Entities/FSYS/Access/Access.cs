using Dapper.Contrib.Extensions;
using System;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.Access")]
    public class Access
    {
        [ExplicitKey]
        public Guid AccessId { get; set; }
        public Guid OwnerId { get; set; }
        public Int16 OwnerType { get; set; }
        public string TagGroupIds { get; set; }
        public Int16 TypeGroupId { get; set; }
    }
    
}
