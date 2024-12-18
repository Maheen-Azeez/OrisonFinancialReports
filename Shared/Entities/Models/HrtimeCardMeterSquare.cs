using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtimeCardMeterSquare
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime Date { get; set; }
        public int EmpId { get; set; }
        public int DesignId { get; set; }
        public int ProjectId { get; set; }
        public string WorkingTime { get; set; }
        public decimal? M2fromSite { get; set; }
        public decimal? M2actual { get; set; }
        public decimal? M2rate { get; set; }
        public decimal? HourRate { get; set; }
        public string Description { get; set; }
        public decimal? Th { get; set; }
        public decimal? Nh { get; set; }
        public decimal? Ot { get; set; }
        public int? Group { get; set; }
        public int? Machine { get; set; }
        public decimal? InspectedArea { get; set; }

        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
        public virtual CostCentre Project { get; set; }
    }
}
