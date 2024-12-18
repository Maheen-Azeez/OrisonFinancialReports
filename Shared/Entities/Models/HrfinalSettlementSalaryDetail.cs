using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrfinalSettlementSalaryDetail
    {
        public int Id { get; set; }
        public int Fsid { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }

        public virtual HrfinalSettlement Fs { get; set; }
    }
}
