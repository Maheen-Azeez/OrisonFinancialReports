using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class OpeningGroupVw
    {
        public int? Parent { get; set; }
        public short BranchId { get; set; }
        public decimal? OpDebit { get; set; }
        public decimal? OpCredit { get; set; }
    }
}
