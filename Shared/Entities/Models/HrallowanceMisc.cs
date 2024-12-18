using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrallowanceMisc
    {
        public HrallowanceMisc()
        {
            HrallowanceMiscDetails = new HashSet<HrallowanceMiscDetail>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public int AllowanceId { get; set; }
        public decimal? Amount { get; set; }
        public int? Postid { get; set; }

        public virtual HrallowanceMast Allowance { get; set; }
        public virtual ICollection<HrallowanceMiscDetail> HrallowanceMiscDetails { get; set; }
    }
}
