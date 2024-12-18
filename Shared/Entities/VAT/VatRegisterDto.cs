using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.VAT
{
    public class VatRegisterDto
    {
        public int AccountID { get; set; }
        public string? AccountName { get; set; }
        public int VID { get; set; }
        public int VEID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? VNo { get; set; }
        public string? InvNo { get; set; }
        public string? VType { get; set; }
        public string? TaxCode { get; set; }
        public string? MainAccountName { get; set; }
        public string? AccCode { get; set; }
        public string? AccName { get; set; }
        public string? Emirates { get; set; }
        public string? TRNNO { get; set; }
        public string? Description { get; set; }
        public Decimal? Debit { get; set; }
        public Decimal? Credit { get; set; }
        public string? RowType { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Decimal? TAXAmt { get; set; }
        public Decimal? ExpTAXAmt { get; set; }
        public Decimal? Diff { get; set; }
        public Decimal? Discount { get; set; }
        public string? TranType { get; set; }
    }
}
