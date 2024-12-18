using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class BillwiseDetailsVw
    {
        public long Vid { get; set; }
        public long Veid { get; set; }
        public string Vno { get; set; }
        public int Vtype { get; set; }
        public string Abr { get; set; }
        public string RefNo { get; set; }
        public int BranchId { get; set; }
        public DateTime Vdate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int AccountId { get; set; }
        public string Description { get; set; }
        public int? Parent { get; set; }
        public string AccountName { get; set; }
        public int? SubGroup { get; set; }
        public int? AccCategory { get; set; }
        public decimal? Paid { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string TranType { get; set; }
        public string PartyName { get; set; }
    }
}
