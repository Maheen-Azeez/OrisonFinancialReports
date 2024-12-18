using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class InvItemRelation
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public int? DitemId { get; set; }
        public decimal? Qty { get; set; }
        public string Description { get; set; }
        public string Field1 { get; set; }
    }
}
