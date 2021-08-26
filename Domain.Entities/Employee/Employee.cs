using Dapper.Contrib.Extensions;
using System;

namespace Domain.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
    }
}
