using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TranLocation
    {
        public long Id { get; set; }
        public long TranId { get; set; }
        public string Location { get; set; }
        public decimal? Qty { get; set; }
    }
}
