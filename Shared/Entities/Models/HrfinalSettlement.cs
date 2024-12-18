using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrfinalSettlement
    {
        public HrfinalSettlement()
        {
            HrfinalSettlementSalaryDetails = new HashSet<HrfinalSettlementSalaryDetail>();
            HrfnlSettlementDetails = new HashSet<HrfnlSettlementDetail>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public DateTime? EndDate { get; set; }
        public string AccountReference { get; set; }
        public decimal? ServiceDays { get; set; }
        public decimal? SalaryTotal { get; set; }
        public decimal? SettlementTotal { get; set; }
        public decimal? NetAmount { get; set; }

        public virtual Account Emp { get; set; }
        public virtual ICollection<HrfinalSettlementSalaryDetail> HrfinalSettlementSalaryDetails { get; set; }
        public virtual ICollection<HrfnlSettlementDetail> HrfnlSettlementDetails { get; set; }
    }
}
