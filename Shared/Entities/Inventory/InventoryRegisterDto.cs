using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class InventoryRegisterDto
    {
        public int ID { get; set; }
        public int VID { get; set; }
        public int ItemID { get; set; }
        public decimal? Qty { get; set; }
        public decimal? FOCQty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? ARate { get; set; }
        public string? Unit { get; set; }
        public decimal? Factor { get; set; }
        public bool IsComplex { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AAmount { get; set; }
        public string? VNo { get; set; }
        public DateTime VDate { get; set; }
        public string? PartyName { get; set; }
        public string? RefNo { get; set; }
        public int WHID { get; set; }
        public string? Description { get; set; }
        public decimal? Addition { get; set; }
        public decimal? Discount { get; set; }
        public decimal? CBM { get; set; }
        public decimal? BasicQty { get; set; }
        public int RowType { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? WHCODE { get; set; }
        public decimal? LastRate { get; set; }
        public decimal? AvgCost { get; set; }
        public bool IsReturn { get; set; }
        public string? Project { get; set; }
        public string? Class { get; set; }
        public string? Division { get; set; }
        public decimal? Balance { get; set; }

        public decimal? AmountIn => RowType == 1 ? Amount : null;
        public decimal? AmountOut => RowType == -1 ? Amount : null;
        public decimal? AAmountIn => RowType == 1 ? AAmount : null;
        public decimal? AAmountOut => RowType == -1 ? AAmount : null;
        public decimal? QtyIn => RowType == 1 ? Qty : null;
        public decimal? QtyOut => RowType == -1 ? Qty : null;
    }
}
