using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class AcctStmt
    {
        public int VID { get; set; }
        public int VEID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string VNo { get; set; }

        public string RefNo { get; set; }
        public string VType { get; set; }
        public string MainAccountName { get; set; }
        public string AccountName { get; set; }
        public string Description { get; set; }
        public string CommonNarration { get; set; }
        public string Narration { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string RowType { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? chequedate { get; set; }
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string Status { get; set; }
        public int OrderNo { get; set; }
        public int AccountId { get; set; }
        public DateTime? modifiedDate { get; set; }
        public double? Balance { get; set; }
        public double? RBalance { get; set; }
    }
}
