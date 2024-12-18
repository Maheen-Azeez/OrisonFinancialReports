using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrprojectInvoice
    {
        public HrprojectInvoice()
        {
            HrprojectInvoiceTrans = new HashSet<HrprojectInvoiceTran>();
        }

        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public DateTime? Date { get; set; }
        public int ProjectId { get; set; }
        public decimal? Total { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Net { get; set; }
        public string RefNo { get; set; }
        public string Attention { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public DateTime? InvoiceDate { get; set; }

        public virtual ICollection<HrprojectInvoiceTran> HrprojectInvoiceTrans { get; set; }
    }
}
