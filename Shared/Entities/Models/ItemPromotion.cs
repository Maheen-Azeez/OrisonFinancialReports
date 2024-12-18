using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemPromotion
    {
        public int Id { get; set; }
        public int ProItemId { get; set; }
        public decimal? Qty { get; set; }
        public string Remarks { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string ProType { get; set; }
        public decimal? ProAmount { get; set; }
        public decimal? ProDiscount { get; set; }
        public int ParentId { get; set; }
        public string Active { get; set; }
    }
}
