using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherEntryDetail
    {
        public long Id { get; set; }
        public long? Vid { get; set; }
        public long? Veid { get; set; }
        public long? ChVeid { get; set; }
        public string RowType { get; set; }
        public int? AccountId { get; set; }
        public decimal? Veddebit { get; set; }
        public decimal? Vedcredit { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string TranType { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public int? NumField1 { get; set; }
        public int? NumField2 { get; set; }

        public virtual Account Account { get; set; }
        public virtual VoucherEntry Ve { get; set; }
        public virtual Voucher VidNavigation { get; set; }
    }
}
