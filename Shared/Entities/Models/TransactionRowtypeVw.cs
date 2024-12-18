using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TransactionRowtypeVw
    {
        public long Vid { get; set; }
        public string Vno { get; set; }
        public DateTime Vdate { get; set; }
        public int BranchId { get; set; }
        public long Id { get; set; }
        public int ItemId { get; set; }
        public string BatchNo { get; set; }
        public int? Whid { get; set; }
        public string Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Basicqty { get; set; }
        public short? Rowtype { get; set; }
        public short? Invoicetype { get; set; }
        public string Unit { get; set; }
        public decimal? Factor { get; set; }
    }
}
