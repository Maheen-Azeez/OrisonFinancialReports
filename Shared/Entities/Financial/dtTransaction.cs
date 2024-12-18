using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class dtTransaction
    {
        public int AccountID { get; set; }
        public string? Branch { get; set; }
        public string? VNO { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Card { get; set; }
        public decimal? Cheque { get; set; }
        public decimal? TT { get; set; }
        public decimal? VAT { get; set; }
        public decimal? Amount { get; set; }
        public string? CommonNarration { get; set; }
        public decimal? ReturnAmt { get; set; }
        public decimal? ReturnProfit { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Profit { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? VDate { get; set; }
        public string? TAXCode { get; set; }
        public string? TRNNo { get; set; }
        public string? Category { get; set; }
        public string? Status { get; set; }

    }
}
