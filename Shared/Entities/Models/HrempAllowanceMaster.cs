using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempAllowanceMaster
    {
        public HrempAllowanceMaster()
        {
            HrempAllowanceDetails = new HashSet<HrempAllowanceDetail>();
        }

        public int Id { get; set; }
        public int AllowanceId { get; set; }
        public string Month { get; set; }
        public int? Year { get; set; }
        public decimal? TotalAmount { get; set; }
        public string Remarks { get; set; }

        public virtual HrallowanceMast Allowance { get; set; }
        public virtual ICollection<HrempAllowanceDetail> HrempAllowanceDetails { get; set; }
    }
}
