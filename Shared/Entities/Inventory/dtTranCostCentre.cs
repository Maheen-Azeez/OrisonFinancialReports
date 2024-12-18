using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class dtTranCostCentre
    {
        public long Id { get; set; }
        public long TranId { get; set; }
        public decimal? SLNo { get; set; }
        public int Ccid { get; set; }
        public int? CostPhaseId { get; set; }
        public int? CostUnitId { get; set; }
        public string Qty { get; set; }
        public decimal BasicQty { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public decimal? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }
        public int? RowType { get; set; }
        public string VarField1 { get; set; }
        public int? StockType { get; set; }
        public string RowState { get; set; }
    }
}
