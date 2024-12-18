using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProductionItemDetail
    {
        public int Id { get; set; }
        public long JobId { get; set; }
        public int ItemId { get; set; }
        public string Size { get; set; }
        public string ClothCode { get; set; }
        public string ModelCloth { get; set; }
        public decimal? Rate { get; set; }
        public int? Qty { get; set; }
        public decimal? TailorCost { get; set; }
        public decimal? MaterialCost { get; set; }
        public decimal? CuttingCost { get; set; }
        public decimal? FinishingCost { get; set; }
        public decimal? Total { get; set; }
        public int? ClothCostQty { get; set; }
        public decimal? ClothCostRate { get; set; }
        public decimal? ClothCostTotal { get; set; }

        public virtual Voucher Job { get; set; }
    }
}
