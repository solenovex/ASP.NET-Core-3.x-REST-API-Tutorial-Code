using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Routine.Api.Models
{
    public class CompanyAddDto
    {
        [Display(Name = "公司名")]
        [Required(ErrorMessage = "{0}这个字段是必填的")]
        [MaxLength(100, ErrorMessage = "{0}的最大长度不可以超过{1}")]
        public string Name { get; set; }

        [Display(Name = "简介")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "{0}的长度范围从{2}到{1}")]
        public string Introduction { get; set; }

        public ICollection<EmployeeAddDto> Employees { get; set; } = new List<EmployeeAddDto>();
    }
}
