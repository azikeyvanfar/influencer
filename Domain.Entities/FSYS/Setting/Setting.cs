using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.FSYS
{
    [Table("FSYS.Setting")]
    public class Setting
    {
        [ExplicitKey]
        public Guid SettingId { get; set; }
        [Display(Name = "کد")]
        public string Code { get; set; }
        [Display(Name = "مقدار")]
        public string Value { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Display(Name = "شرکت")]
        public Guid CompanyId { get; set; }
    }
}