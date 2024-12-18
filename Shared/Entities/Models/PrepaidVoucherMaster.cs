using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class PrepaidVoucherMaster
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Jvdate { get; set; }
        public int? PartyAccountId { get; set; }
        public int? PrepaidAccountid { get; set; }
        public int? RentExpenseId { get; set; }
        public string Description { get; set; }
        public string Narration { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? Installments { get; set; }
        public decimal? Amount { get; set; }
        public string VarField1 { get; set; }
        public int? NumField1 { get; set; }
        public DateTime? DateField1 { get; set; }

        public virtual Account PartyAccount { get; set; }
        public virtual Account PrepaidAccount { get; set; }
    }
}
