using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VentryAccount
    {
        public long Id { get; set; }
        public long? Veid { get; set; }
        public long? AccountId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Description { get; set; }

        public virtual VoucherEntry Ve { get; set; }
    }
}
