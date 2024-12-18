using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrisonMIS.Shared.Entities.Financial
{
    public class Consolidated
    {
        public int? ID { get; set; }
        public int? VoucherEntry { get; set; }
        public int? ParentID { get; set; }
        public int? ParentLevel { get; set; }
        public string AccCategory { get; set; }
        public string SubGroup { get; set; }
        public string AccountGroup { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public string Phone1 { get; set; }
        public string Mobile { get; set; }
        public string ContactPerson { get; set; }
        public double? Amt0_30 { get; set; }
        public double? Amt31_60 { get; set; }
        public double? Amt61_90 { get; set; }
        public double? Amt91_120 { get; set; }
        public double? Amt_120 { get; set; }
        public decimal? M1 { get; set; }
        public decimal? M2 { get; set; }
        public decimal? M3 { get; set; }
        public decimal? M4 { get; set; }
        public decimal? M5 { get; set; }
        public decimal? M6 { get; set; }
        public decimal? M7 { get; set; }
        public decimal? M8 { get; set; }
        public decimal? M9 { get; set; }
        public decimal? M10 { get; set; }
        public decimal? M11 { get; set; }
        public decimal? M12 { get; set; }
        public decimal? M13 { get; set; }
        public decimal? SortField { get; set; }
        public decimal? PrevDebit { get; set; }
        public decimal? PrevCredit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public double? UnAllocated { get; set; }
        public double? Balance { get; set; }
        public double? AccBalance { get; set; }
        public string? Branch { get; set; }
    }
}
