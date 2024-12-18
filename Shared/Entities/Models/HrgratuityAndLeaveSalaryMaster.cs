using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrgratuityAndLeaveSalaryMaster
    {
        public HrgratuityAndLeaveSalaryMaster()
        {
            HrgratuityAndLeaveSalaryTrans = new HashSet<HrgratuityAndLeaveSalaryTran>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal? GratuityTotal { get; set; }
        public decimal? LeaveSalaryTotal { get; set; }
        public decimal? TicketTotal { get; set; }
        public decimal? Total { get; set; }
        public long? PostId { get; set; }
        public decimal? InsuranceTotal { get; set; }

        public virtual ICollection<HrgratuityAndLeaveSalaryTran> HrgratuityAndLeaveSalaryTrans { get; set; }
    }
}
