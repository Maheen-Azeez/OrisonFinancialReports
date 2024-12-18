using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Inventory
{
    public class StockRegisterDto
    {
        public int ID { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public decimal? SellingPrice { get; set; }
        public string? OEMNo { get; set; }
        public string? PartNo { get; set; }
        public string? Manufacturer { get; set; }
        public string? BarCode { get; set; }
        public string? ModelNo { get; set; }
        public string? Unit { get; set; }
        public string? Remarks { get; set; }
        public bool? IsGroup { get; set; }
        public bool? StockItem { get; set; }
        public bool? Inactive { get; set; }
        public int? InvAccountID { get; set; }
        public decimal? Stock { get; set; }
        public decimal? StockInUnit { get; set; }
        public string? StockInBasic { get; set; }
        public decimal? InvoicedQty { get; set; }
        public decimal? Cost { get; set; }
        public decimal? LastPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CreatedUserID { get; set; }
        public int? ModifiedUserID { get; set; }
        public int? BranchID { get; set; }
        public int? CategoryID { get; set; }
        public string? Category { get; set; }
        public string? Location { get; set; }
        public string? MajorGroup { get; set; }
        public string? MiddleGroup { get; set; }
        public string? MinorGroup { get; set; }
        public decimal? CashPrice { get; set; }
        public decimal? CreditPrice { get; set; }
        public decimal? ROQ { get; set; }
        public decimal? ROL { get; set; }
        public string? Field1 { get; set; }
        public string? Field2 { get; set; }
        public string? Field3 { get; set; }
        public string? Field4 { get; set; }
        public string? Field5 { get; set; }
        public string? Rating { get; set; }
    }
}
