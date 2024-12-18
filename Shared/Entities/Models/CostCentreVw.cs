using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CostCentreVw
    {
        public long Id { get; set; }
        public long? Veid { get; set; }
        public int Ccid { get; set; }
        public string CostCentre { get; set; }
        public int? CostPhaseId { get; set; }
        public int? CostUnitId { get; set; }
        public string Phase { get; set; }
        public string CostUnit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Description { get; set; }
        public long Vid { get; set; }
        public int? CostCategoryId { get; set; }
        public string CostCategory { get; set; }
    }
}
