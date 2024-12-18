using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class JobOutSide
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int RefNo { get; set; }
        public string JobOrderNo { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string FileName { get; set; }
        public string Program { get; set; }
        public string ColourMode { get; set; }
        public string Media { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Place { get; set; }
        public int? Dono { get; set; }
        public int? InvoiceNo { get; set; }
        public string ReceiverName { get; set; }
        public string Remarks { get; set; }
    }
}
