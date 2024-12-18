using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ChequesTran
    {
        public long Id { get; set; }
        public long? Vid { get; set; }
        public long? Veid { get; set; }
        public int ChequeId { get; set; }
        public string TranType { get; set; }
        public DateTime? Todate { get; set; }

        public virtual VoucherEntry Ve { get; set; }
    }
}
