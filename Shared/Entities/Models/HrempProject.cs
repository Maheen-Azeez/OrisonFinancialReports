using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempProject
    {
        public int Id { get; set; }
        public string TrNo { get; set; }
        public DateTime? Tdate { get; set; }
        public int? ProjectCode { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Remarks { get; set; }
        public string ApprovedBy { get; set; }

        public virtual CostCentre ProjectCodeNavigation { get; set; }
    }
}
