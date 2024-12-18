using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EstimateProject
    {
        public EstimateProject()
        {
            EstimationItems = new HashSet<EstimationItem>();
            EstimationOtherItems = new HashSet<EstimationOtherItem>();
        }

        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Date { get; set; }
        public int ProjectId { get; set; }
        public int? ClientId { get; set; }
        public decimal? ContractValue { get; set; }
        public decimal? NetAmount { get; set; }
        public decimal? ItemAmount { get; set; }
        public decimal? OtherAmount { get; set; }
        public string Remarks { get; set; }

        public virtual CostCentre Project { get; set; }
        public virtual ICollection<EstimationItem> EstimationItems { get; set; }
        public virtual ICollection<EstimationOtherItem> EstimationOtherItems { get; set; }
    }
}
