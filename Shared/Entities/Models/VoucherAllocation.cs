using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class VoucherAllocation
    {
        public int Id { get; set; }
        public long Vid { get; set; }
        public long Veid { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
