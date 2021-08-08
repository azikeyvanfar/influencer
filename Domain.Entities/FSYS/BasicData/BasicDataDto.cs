using System;

namespace Domain.Entities.FSYS
{
    public class BasicDataDto
    {
        public int Row { get; set; }
        public BasicData BasicData { get; set; }
        public String CompanyName { get; set; }
        public int TotalCount { get; set; }
    }
}
