using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EstimationItem
    {
        public int Id { get; set; }
        public int Eid { get; set; }
        public int ItemId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string Unit { get; set; }
        public decimal? Factor { get; set; }
        public decimal? BasicQty { get; set; }
        public int? AccountId { get; set; }

        public virtual EstimateProject EidNavigation { get; set; }
        public virtual ItemMaster Item { get; set; }
        public virtual UnitMaster UnitNavigation { get; set; }
    }
}
