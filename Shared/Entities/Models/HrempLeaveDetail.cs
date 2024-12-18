using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempLeaveDetail
    {
        public HrempLeaveDetail()
        {
            HrleaveImages = new HashSet<HrleaveImage>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string LeaveType { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Reason { get; set; }
        public decimal? Duration { get; set; }
        public int? OpeningBalance { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Remarks { get; set; }
        public decimal? Waitage { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string Status { get; set; }
        public string Period { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public int? RequestId { get; set; }
        public string Source { get; set; }
        public DateTime? WorkRejoinDate { get; set; }
        public DateTime? LastWorkedDate { get; set; }
        public string Salaryhold { get; set; }
        public DateTime? SalaryholdFrom { get; set; }
        public DateTime? SalaryholdTo { get; set; }
        public string Guarantor { get; set; }
        public int? Guarantor1Id { get; set; }
        public int? Guarantor2Id { get; set; }
        public decimal? Guarantor1Amt { get; set; }
        public decimal? Guarantor2Amt { get; set; }
        public int? ProjectId { get; set; }
        public string LeaveStatus { get; set; }
        public decimal? PaidHolidays { get; set; }
        public bool? Settled { get; set; }
        public string Refno { get; set; }

        public virtual Account Emp { get; set; }
        public virtual CostCentre LeaveTypeNavigation { get; set; }
        public virtual ICollection<HrleaveImage> HrleaveImages { get; set; }
    }
}
