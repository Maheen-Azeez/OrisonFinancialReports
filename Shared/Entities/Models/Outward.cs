using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Outward
    {
        public int? TranId { get; set; }
        public int? ItemId { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? Tdate { get; set; }
    }
}
