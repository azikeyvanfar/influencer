using Domain.Entities.FORG;
using System;

namespace EndPoint.WebUI.Models
{
    public class UserPerson
    {
        public User User { get; set; }
        //public Person Person { get; set; }
        //public Role Role { get; set; }
        public Guid PersonId { get; set; }
        public bool HasPerson { get; set; }
        public string RoleIds { get; set; }
    }
}
