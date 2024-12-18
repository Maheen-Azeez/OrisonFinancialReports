using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VentryCostCentre
    {
        public long Id { get; set; }
        public long? Veid { get; set; }
        public int Ccid { get; set; }
        public int? CostPhaseId { get; set; }
        public int? CostUnitId { get; set; }
        public int? CostCategoryId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Description { get; set; }

        public virtual CostCentre Cc { get; set; }
        public virtual CostCategoryMast CostCategory { get; set; }
        public virtual CostPhaseMast CostPhase { get; set; }
        public virtual CostUnitMast CostUnit { get; set; }
        public virtual VoucherEntry Ve { get; set; }
    }
}
