using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BudgetTran
    {
        public BudgetTran()
        {
            BudgetCostCentres = new HashSet<BudgetCostCentre>();
        }

        public int Id { get; set; }
        public int Bid { get; set; }
        public int? AccountId { get; set; }
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

        public virtual BudgetMaster BidNavigation { get; set; }
        public virtual ICollection<BudgetCostCentre> BudgetCostCentres { get; set; }
    }
}
