using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtimeSheetConsolidated
    {
        public int Id { get; set; }
        public int Tid { get; set; }
        public string Project { get; set; }
        public decimal? Days { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Hot { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Fot { get; set; }
        public string Remarks { get; set; }

        public virtual CostCentre ProjectNavigation { get; set; }
        public virtual HrtimeSheet TidNavigation { get; set; }
    }
}
