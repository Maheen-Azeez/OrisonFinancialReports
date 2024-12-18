using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class OrisonVoucherVw
    {
        public string Vno { get; set; }
        public string RefNo { get; set; }
        public DateTime Vdate { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
    }
}
