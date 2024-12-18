using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtimeSheetDetail
    {
        public int Id { get; set; }
        public int Tsid { get; set; }
        public DateTime? Date { get; set; }
        public string DayType { get; set; }
        public string Project { get; set; }
        public string RefNo { get; set; }
        public decimal? Th { get; set; }
        public decimal? Nh { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Hot { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Crate { get; set; }
        public decimal? Amount { get; set; }
        public string Designation { get; set; }

        public virtual CostCentre ProjectNavigation { get; set; }
        public virtual HrtimeSheet Ts { get; set; }
    }
}
