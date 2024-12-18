using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProductionDailyTran
    {
        public long Id { get; set; }
        public long MastId { get; set; }
        public string JobNo { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }
        public string BatchNo { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CuttingQty { get; set; }
        public decimal? StitchingQty { get; set; }
        public decimal? FinishingQty { get; set; }
        public int? EmpId { get; set; }
        public decimal? FinishedQty { get; set; }
        public string Remarks { get; set; }
        public decimal? EmpRate { get; set; }

        public virtual ProductionDailyMast Mast { get; set; }
    }
}
