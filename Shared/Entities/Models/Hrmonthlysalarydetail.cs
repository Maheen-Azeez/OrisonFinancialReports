using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrmonthlysalarydetail
    {
        public int Id { get; set; }
        public int? Msid { get; set; }
        public int? AllowanceId { get; set; }
        public decimal? Amount { get; set; }

        public virtual HrallowanceMast Allowance { get; set; }
        public virtual HrmonthlyStaffdetail Ms { get; set; }
    }
}
