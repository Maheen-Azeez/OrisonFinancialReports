using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrleaveSalary
    {
        public int Id { get; set; }
        public int? Lid { get; set; }
        public DateTime Date { get; set; }
        public int EmpId { get; set; }
        public decimal? Days { get; set; }
        public decimal? LeaveSalary { get; set; }
        public decimal? AirTicket { get; set; }
        public decimal? Total { get; set; }
        public DateTime? FromDate { get; set; }
        public decimal? SplitAmount1 { get; set; }
        public decimal? SplitAmount2 { get; set; }
        public bool? Split { get; set; }

        public virtual HrleaveSalaryMast LidNavigation { get; set; }
    }
}
