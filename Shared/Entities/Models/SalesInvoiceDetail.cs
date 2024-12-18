using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SalesInvoiceDetail
    {
        public int Id { get; set; }
        public int Siid { get; set; }
        public int CustId { get; set; }
        public string Place { get; set; }
        public int? ItemId { get; set; }
        public string Qty { get; set; }
        public decimal? Rate { get; set; }
        public string Cbsold { get; set; }
        public decimal? CbsoldRate { get; set; }
        public string CleafRtd { get; set; }
        public string Amount { get; set; }
        public string OpBalance { get; set; }
        public string Cash { get; set; }
        public string Credit { get; set; }
        public string Discount { get; set; }
        public string Balance { get; set; }
        public string Remarks { get; set; }
        public int? BottleReturned { get; set; }
        public string Reason { get; set; }

        public virtual Account Cust { get; set; }
        public virtual SalesInvoice Si { get; set; }
    }
}
