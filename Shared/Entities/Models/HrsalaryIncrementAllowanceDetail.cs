using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrsalaryIncrementAllowanceDetail
    {
        public int Id { get; set; }
        public int? Siid { get; set; }
        public int? Sieid { get; set; }
        public int? AllowanceId { get; set; }
        public decimal? OldTotal { get; set; }
        public decimal? Increment { get; set; }
        public decimal? NewTotal { get; set; }

        public virtual HrallowanceMast Allowance { get; set; }
        public virtual HrsalaryIncrementMast Si { get; set; }
        public virtual HrsalaryIncrementEmpDetail Sie { get; set; }
    }
}
