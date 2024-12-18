using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemSublist
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int? MainItemId { get; set; }
        public decimal? MainItemQty { get; set; }
        public decimal? Rate { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }

        public virtual ItemMaster Item { get; set; }
    }
}
