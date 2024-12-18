using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CostPhaseMast
    {
        public CostPhaseMast()
        {
            HrtimeCardDetails = new HashSet<HrtimeCardDetail>();
            TranCostCentres = new HashSet<TranCostCentre>();
            VentryCostCentres = new HashSet<VentryCostCentre>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public int? Ccid { get; set; }

        public virtual ICollection<HrtimeCardDetail> HrtimeCardDetails { get; set; }
        public virtual ICollection<TranCostCentre> TranCostCentres { get; set; }
        public virtual ICollection<VentryCostCentre> VentryCostCentres { get; set; }
    }
}
