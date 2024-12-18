using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempWagesDeduction
    {
        public int Id { get; set; }
        public int Wiid { get; set; }
        public int? DeductionId { get; set; }
        public decimal? Amount { get; set; }

        public virtual MasterMisc Deduction { get; set; }
        public virtual HrempWage Wi { get; set; }
    }
}
