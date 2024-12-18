using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherCollection
    {
        public int Id { get; set; }
        public long? Vid { get; set; }
        public int? AccountId { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public string VarField3 { get; set; }
        public int? NumField1 { get; set; }
        public int? NumField2 { get; set; }
        public int? NumField3 { get; set; }

        public virtual Account Account { get; set; }
        public virtual Voucher VidNavigation { get; set; }
    }
}
