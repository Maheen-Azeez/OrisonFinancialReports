using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrcampAttendance
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public int EmpId { get; set; }
        public string DayType { get; set; }
        public int? DesignId { get; set; }
        public int? ProjectId { get; set; }
        public decimal? Crate { get; set; }
        public decimal? Erate { get; set; }
        public decimal Th { get; set; }
        public decimal? Nh { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Hot { get; set; }
        public string Type { get; set; }
        public decimal? Deduction { get; set; }
        public string Remark { get; set; }
        public string Shift { get; set; }
        public int? CampId { get; set; }
        public string CampRoom { get; set; }
        public string Grade { get; set; }

        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
        public virtual CostCentre Project { get; set; }
    }
}
