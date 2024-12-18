using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProductionSubDetail
    {
        public long Id { get; set; }
        public long ParentId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal? Rate { get; set; }

        public virtual Transaction Parent { get; set; }
    }
}
