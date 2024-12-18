using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ProdManpower
    {
        public int Id { get; set; }
        public long Vid { get; set; }
        public string Designation { get; set; }
        public decimal Rate { get; set; }
        public decimal Hours { get; set; }
        public decimal Amount { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
