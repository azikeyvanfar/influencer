using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    //[Table("dbo.Employee")]
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
