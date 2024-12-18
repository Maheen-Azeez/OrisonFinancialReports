using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempProjectTran
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string ProjectCode { get; set; }
        public int? DesignId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Status { get; set; }
        public string TrNo { get; set; }
        public string RefNo { get; set; }
        public string Remarks { get; set; }
        public string Source { get; set; }

        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
        public virtual CostCentre ProjectCodeNavigation { get; set; }
        public virtual HrprojectTransfer RefNoNavigation { get; set; }
    }
}
