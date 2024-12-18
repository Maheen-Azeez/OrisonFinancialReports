using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Fadetail
    {
        public long Id { get; set; }
        public string AssetNo { get; set; }
        public string SlNo { get; set; }
        public string IndexNo { get; set; }
        public int? BranchId { get; set; }
        public decimal? SalesPrice { get; set; }
        public string InvoiceRef { get; set; }
        public string PurchaseRef { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Vendor { get; set; }
        public string Remarks { get; set; }
        public DateTime? DtField1 { get; set; }
        public DateTime? DtField2 { get; set; }
        public DateTime? DtField3 { get; set; }
        public string TxtField1 { get; set; }
        public string TxtField2 { get; set; }
        public string TxtField3 { get; set; }
        public string PartNo { get; set; }
        public int? StaffId { get; set; }
        public int? Qty { get; set; }
        public int? Accountid { get; set; }
    }
}
