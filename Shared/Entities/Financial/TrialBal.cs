using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class TrialBal
    {
        public int? ID { get; set; }
        public int? ParentID { get; set; }
        public int? VoucherEntry { get; set; }
        public int? AccountGroupID { get; set; }
        public int? SubGroupOrderNo { get; set; }
        public int? ParentLevel { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public bool ShowChild { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Dr { get; set; }
        public decimal? Cr { get; set; }
        public decimal? OpDr { get; set; }
        public decimal? OpCr { get; set; }
        public decimal? CurDr { get; set; }
        public decimal? CurCr { get; set; }
        public decimal? TotalDr { get; set; }
        public decimal? TotalCr { get; set; }
        public decimal? SortField { get; set; }
        public bool ShowRow { get; set; }
        public int? AcccategoryID { get; set; }

    }
}
