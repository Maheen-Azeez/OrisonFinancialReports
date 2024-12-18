using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtimeCardDetail
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
        public string InvoiceNo { get; set; }
        public decimal? Ihour { get; set; }
        public decimal? Hm { get; set; }
        public decimal? InTime { get; set; }
        public decimal? OutTime { get; set; }
        public string JobOrderNo { get; set; }
        public string SupplierInvoiceNo { get; set; }
        public int? CostPhaseId { get; set; }
        public decimal? Nch { get; set; }
        public decimal? Cot { get; set; }
        public decimal? Chot { get; set; }
        public string Source { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }

        public virtual CostPhaseMast CostPhase { get; set; }
        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
        public virtual CostCentre Project { get; set; }
    }
}
