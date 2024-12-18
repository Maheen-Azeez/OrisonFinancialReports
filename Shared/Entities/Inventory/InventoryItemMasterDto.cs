using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class InventoryItemMasterDto
    {
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? BarCode { get; set; }
        public int ID { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal Stock { get; set; }
        public string? Unit { get; set; }
        public string? BasicUnit { get; set; }
        public decimal LastCost { get; set; } 
        public decimal AvgCost { get; set; }
        public decimal AStock { get; set; }
        public decimal Factor { get; set; }
        public bool IsComplex { get; set; }
        public int? InvAccountID { get; set; }
        public string? InvAccount { get; set; }
        public int? CostAccountID { get; set; }
        public string? CostAccount { get; set; }
        public int? PurchaseAccountID { get; set; }
        public string? PurchaseAccount { get; set; }
        public int? SalesAccountID { get; set; }
        public string? SalesAccount { get; set; }
        public bool IsGroup { get; set; }
        public bool StockItem { get; set; }
        public string? NoSpaceItemCode { get; set; }
        public string? MajorGroup { get; set; }
        public string? MiddleGroup { get; set; }
        public string? MinorGroup { get; set; }
        public string? Category { get; set; }
        public decimal CashPrice { get; set; }
        public decimal CreditPrice { get; set; }
        public string? ModelNo { get; set; }
        public string? Manufacturer { get; set; }
        public string? Location { get; set; }
        public decimal VATPer { get; set; }
        public decimal ExcisePercen { get; set; }
        public string? Field1 { get; set; }
        public string? Field2 { get; set; }
        public string? Field3 { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? UOM { get; set; }
        public bool FixedAssetItem { get; set; }
    }
}
