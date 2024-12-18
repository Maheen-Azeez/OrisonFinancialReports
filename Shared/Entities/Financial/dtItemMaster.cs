using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class dtItemMaster
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal? SellingPrice { get; set; }
        public string Oemno { get; set; }
        public string PartNo { get; set; }
        public int? CategoryId { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string BarCode { get; set; }
        public string ModelNo { get; set; }
        public string Unit { get; set; }
        public decimal? Rol { get; set; }
        public string Remarks { get; set; }
        public bool IsGroup { get; set; }
        public bool? StockItem { get; set; }
        public bool Inactive { get; set; }
        public int? InvAccountId { get; set; }
        public int? CostAccountId { get; set; }
        public int? PurchaseAccountId { get; set; }
        public int? SalesAccountId { get; set; }
        public string InvAccount { get; set; }
        public string CostAccount { get; set; }
        public string PurchaseAccount { get; set; }
        public string SalesAccount { get; set; }
        public decimal? Stock { get; set; }
        public decimal? InvoicedStock { get; set; }
        public decimal? AvgCost { get; set; }
        public decimal? LastCost { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public int? BranchId { get; set; }
        public string Location { get; set; }
        public string MajorGroup { get; set; }
        public string MiddleGroup { get; set; }
        public string MinorGroup { get; set; }
        public decimal? CashPrice { get; set; }
        public decimal? CreditPrice { get; set; }
        public decimal? Roq { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public DateTime? PurDate { get; set; }
        public bool FixedAssetItem { get; set; }
        public decimal? ExcisePercen { get; set; }
        public string Vatpercen { get; set; }
        public decimal? Vrate { get; set; }
        public string Criteria { get; set; }
    }
}
