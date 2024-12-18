using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BudgetCostCentre
    {
        public int Id { get; set; }
        public int BtrId { get; set; }
        public int Ccid { get; set; }
        public decimal? Amount { get; set; }
        public decimal? January { get; set; }
        public decimal? February { get; set; }
        public decimal? March { get; set; }
        public decimal? April { get; set; }
        public decimal? May { get; set; }
        public decimal? June { get; set; }
        public decimal? July { get; set; }
        public decimal? August { get; set; }
        public decimal? September { get; set; }
        public decimal? October { get; set; }
        public decimal? November { get; set; }
        public decimal? December { get; set; }

        public virtual BudgetTran Btr { get; set; }
        public virtual CostCentre Cc { get; set; }
    }
}
