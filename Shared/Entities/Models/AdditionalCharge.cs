using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AdditionalCharge
    {
        public long Id { get; set; }
        public long Vid { get; set; }
        public int? DrAccountId { get; set; }
        public int CrAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public bool IsFixed { get; set; }
        public bool Active { get; set; }
        public long? Veiddr { get; set; }
        public long? Veidcr { get; set; }
        public string DrorCr { get; set; }
        public string InvNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string Trnno { get; set; }
        public decimal? Vat { get; set; }
        public long? Veidvatdr { get; set; }
        public long? Veidvatcr { get; set; }
        public string Tcode { get; set; }

        public virtual Account CrAccount { get; set; }
        public virtual Account DrAccount { get; set; }
        public virtual Voucher VidNavigation { get; set; }
    }
}
