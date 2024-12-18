using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TourismRateMaster
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int PostTo { get; set; }
        public string Type { get; set; }
        public decimal? Amount { get; set; }
        public string Provider { get; set; }
        public string Category { get; set; }
        public string Remarks { get; set; }

        public virtual Account PostToNavigation { get; set; }
    }
}
