using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrinvoice
    {
        public Hrinvoice()
        {
            HrinvoiceDetails = new HashSet<HrinvoiceDetail>();
        }

        public int Id { get; set; }
        public string Month { get; set; }
        public int? Year { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public DateTime? Date { get; set; }
        public int ProjectId { get; set; }
        public string InvoiceNo { get; set; }
        public string Remarks { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Additional { get; set; }
        public decimal? GrandTotal { get; set; }
        public string Terms { get; set; }
        public string RefNo { get; set; }
        public int? PostId { get; set; }
        public string VoucherNo { get; set; }
        public bool? IsCancelled { get; set; }
        public string Lporeference { get; set; }
        public DateTime? Lpodate { get; set; }
        public decimal? Discount { get; set; }
        public string Wbranch { get; set; }
        public string LporeferenceExtra { get; set; }
        public DateTime? LpodateExtra { get; set; }
        public decimal? Vatamt { get; set; }
        public decimal? Vatpaid { get; set; }
        public decimal? Total { get; set; }
        public string Trnno { get; set; }
        public string Emirates { get; set; }
        public string Taxcode { get; set; }

        public virtual ICollection<HrinvoiceDetail> HrinvoiceDetails { get; set; }
    }
}
