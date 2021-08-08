using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.BasicData")]
    public class BasicData
    {
        [ExplicitKey]
        public Guid BasicDataId { get; set; }
        public string Value { get; set; }
        [Required(ErrorMessage = "کد متن را وارد نمایید")]
        [Display(Name = "متن")]
        public string Text { get; set; }
        public int ViewOrder { get; set; }
        public string GroupKey { get; set; }
        public bool Editable { get; set; }
        public Guid? CompanyId { get; set; }
        [Display(Name = "کد")]
        public string Code { get; set; }
    }
}
