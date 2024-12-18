using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherCurrencyDetail
    {
        public int Id { get; set; }
        public long Vid { get; set; }
        public int Cmid { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Famount { get; set; }

        public virtual CurrencyMast Cm { get; set; }
    }
}
