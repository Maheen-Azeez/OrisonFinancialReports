using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherEntryAdditional
    {
        public long Id { get; set; }
        public long Veid { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public int? NumField1 { get; set; }
        public decimal? NumField2 { get; set; }
        public decimal? NumField3 { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public string Image { get; set; }

        public virtual VoucherEntry Ve { get; set; }
    }
}
