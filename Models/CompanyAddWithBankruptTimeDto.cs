using System;

namespace Routine.Api.Models
{
    public class CompanyAddWithBankruptTimeDto : CompanyAddDto
    {
        public DateTime BankruptTime { get; set; }
    }
}
