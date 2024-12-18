using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ItemPromotionMaster
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int? ProId { get; set; }
        public bool? Active { get; set; }
        public string Remarks { get; set; }
    }
}
