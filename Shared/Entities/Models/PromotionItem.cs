using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PromotionItem
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public int ItemId { get; set; }
        public DateTime? ExpDate { get; set; }
        public decimal? Percentage { get; set; }
        public short? Bonus { get; set; }

        public virtual ItemMaster Item { get; set; }
        public virtual Promotion RefNoNavigation { get; set; }
    }
}
