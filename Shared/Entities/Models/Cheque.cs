using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Cheque
    {
        public int Id { get; set; }
        public long Veid { get; set; }
        public int? CardType { get; set; }
        public decimal? Commission { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public int? ClrDays { get; set; }
        public int? BankId { get; set; }
        public string BankName { get; set; }
        public string Status { get; set; }
        public int? PartyId { get; set; }

        public virtual Account Bank { get; set; }
        public virtual CardMast CardTypeNavigation { get; set; }
        public virtual Account Party { get; set; }
        public virtual VoucherEntry Ve { get; set; }
    }
}
