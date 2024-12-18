using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AvgCostNew
    {
        public long Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int ItemId { get; set; }
        public int? BranchId { get; set; }
        public decimal LastRate { get; set; }
        public decimal AvgCost { get; set; }
        public string BatchNo { get; set; }

        public virtual Company Branch { get; set; }
        public virtual ItemMaster Item { get; set; }
    }
}
