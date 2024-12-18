using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrallowanceMast
    {
        public HrallowanceMast()
        {
            HrallowanceMiscs = new HashSet<HrallowanceMisc>();
            HrallowanceMiscwithoutPayrolls = new HashSet<HrallowanceMiscwithoutPayroll>();
            HrempAllowanceMasters = new HashSet<HrempAllowanceMaster>();
            HrempSalaries = new HashSet<HrempSalary>();
            Hrmonthlysalarydetails = new HashSet<Hrmonthlysalarydetail>();
            HrsalaryIncrementAllowanceDetails = new HashSet<HrsalaryIncrementAllowanceDetail>();
        }

        public int Id { get; set; }
        public string SalaryMode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int? PriorityNo { get; set; }
        public bool? IsFixed { get; set; }

        public virtual ICollection<HrallowanceMisc> HrallowanceMiscs { get; set; }
        public virtual ICollection<HrallowanceMiscwithoutPayroll> HrallowanceMiscwithoutPayrolls { get; set; }
        public virtual ICollection<HrempAllowanceMaster> HrempAllowanceMasters { get; set; }
        public virtual ICollection<HrempSalary> HrempSalaries { get; set; }
        public virtual ICollection<Hrmonthlysalarydetail> Hrmonthlysalarydetails { get; set; }
        public virtual ICollection<HrsalaryIncrementAllowanceDetail> HrsalaryIncrementAllowanceDetails { get; set; }
    }
}
