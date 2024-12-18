using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class LedgerVwsimple
    {
        public string Vno { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int BranchId { get; set; }
        public string RefNo { get; set; }
        public string CommonNarration { get; set; }
        public string MainAccountName { get; set; }
        public string RowType { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public long Vid { get; set; }
        public string AccountName { get; set; }
        public string Vtype { get; set; }
        public int DocumentType { get; set; }
        public int? BasicType { get; set; }
        public string Abbreviation { get; set; }
        public decimal? BasicDebit { get; set; }
        public decimal? BasicCredit { get; set; }
        public decimal? ForeignDebit { get; set; }
        public decimal? ForeignCredit { get; set; }
        public long Veid { get; set; }
        public bool FinalAccount { get; set; }
        public int? Parent { get; set; }
        public int AccountGroup { get; set; }
        public int? OrderNo { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
