using System;

namespace Domain.Entities.FORG
{
    public class UserDto
    {
        public int Row { get; set; }
        public User User { get; set; }
        public string PersonName { get; set; }
        public string CompanyName { get; set; }
        public DateTime LoginDateTime { get; set; }
        public int TotalCount { get; set; }

    }
}
