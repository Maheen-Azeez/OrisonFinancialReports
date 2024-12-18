using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrleaveSettlement
    {
        public HrleaveSettlement()
        {
            HrleaveSettlementDetails = new HashSet<HrleaveSettlementDetail>();
            HrleaveSettlementSalaryDetails = new HashSet<HrleaveSettlementSalaryDetail>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string AccountReference { get; set; }
        public DateTime? LastRejoinDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Days { get; set; }
        public decimal? Lopdays { get; set; }
        public decimal? SalaryTotal { get; set; }
        public decimal? SettlementTotal { get; set; }
        public decimal? NetAmount { get; set; }
        public string LeaveType { get; set; }
        public decimal? ApprovedDays { get; set; }
        public decimal? BalanceDays { get; set; }
        public decimal? DeductionTotal { get; set; }
        public DateTime? LastSettlementDate { get; set; }
        public string LeaveSalary { get; set; }
        public string AIrfAre { get; set; }
        public int? PostId { get; set; }

        public virtual ICollection<HrleaveSettlementDetail> HrleaveSettlementDetails { get; set; }
        public virtual ICollection<HrleaveSettlementSalaryDetail> HrleaveSettlementSalaryDetails { get; set; }
    }
}
