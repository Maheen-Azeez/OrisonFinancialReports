using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            PromotionItems = new HashSet<PromotionItem>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public string PromoType { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? Percentage { get; set; }
        public short? Bonus { get; set; }
        public string Remarks { get; set; }
        public bool? Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedUser { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public int? DeacivatedUser { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<PromotionItem> PromotionItems { get; set; }
    }
}
