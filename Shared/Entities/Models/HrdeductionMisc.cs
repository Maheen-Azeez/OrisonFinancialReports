using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdeductionMisc
    {
        public HrdeductionMisc()
        {
            HrdeductionMiscDetails = new HashSet<HrdeductionMiscDetail>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public string Deduction { get; set; }
        public decimal? Amount { get; set; }
        public int? Postid { get; set; }

        public virtual ICollection<HrdeductionMiscDetail> HrdeductionMiscDetails { get; set; }
    }
}
