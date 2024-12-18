using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Wpstran
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string EmpUniqueId { get; set; }
        public string AgentId { get; set; }
        public string EmpBankAccountNo { get; set; }
        public decimal? IncomeFixed { get; set; }
        public decimal? IncomeVariable { get; set; }
        public int? DaysOnLeave { get; set; }
        public string EmpName { get; set; }
        public string EmpCode { get; set; }
        public string Designation { get; set; }

        public virtual Wpsmaster Parent { get; set; }
    }
}
