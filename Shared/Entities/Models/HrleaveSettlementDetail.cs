using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrleaveSettlementDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? Days { get; set; }
        public decimal Amount { get; set; }
        public int Lsid { get; set; }
        public int? AccountId { get; set; }
        public string AccountCode { get; set; }
        public string Type { get; set; }

        public virtual HrleaveSettlement Ls { get; set; }
    }
}
