using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{ 
    public class dtVentryCostCentre
    {
        public long Id { get; set; }
        public long? Veid { get; set; }
        public decimal? SLNo { get; set; }
        public int Ccid { get; set; }
        public int? CostPhaseId { get; set; }
        public int? CostUnitId { get; set; }
        public int? CostCategoryId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Description { get; set; }
        public string RowState { get; set; }
    }
}
