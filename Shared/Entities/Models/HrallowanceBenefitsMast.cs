using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrallowanceBenefitsMast
    {
        public HrallowanceBenefitsMast()
        {
            HrallowanceBenefitsDetails = new HashSet<HrallowanceBenefitsDetail>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string RefNo { get; set; }
        public int? AllowanceId { get; set; }
        public string AccYear { get; set; }
        public decimal? Amount { get; set; }

        public virtual ICollection<HrallowanceBenefitsDetail> HrallowanceBenefitsDetails { get; set; }
    }
}
