using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PurgeStock
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public DateTime? EffDate { get; set; }
        public decimal? Stock { get; set; }
        public string Batch { get; set; }
        public int BranchId { get; set; }
    }
}
