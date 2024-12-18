using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempSalary
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int AllowanceId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Total { get; set; }

        public virtual HrallowanceMast Allowance { get; set; }
        public virtual Account Emp { get; set; }
    }
}
