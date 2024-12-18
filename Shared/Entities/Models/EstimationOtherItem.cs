using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EstimationOtherItem
    {
        public int Id { get; set; }
        public int Eid { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }

        public virtual EstimateProject EidNavigation { get; set; }
    }
}
