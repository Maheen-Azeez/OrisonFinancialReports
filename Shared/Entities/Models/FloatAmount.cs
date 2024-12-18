using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FloatAmount
    {
        public long Id { get; set; }
        public string Vno { get; set; }
        public DateTime? Vdate { get; set; }
        public int? BranchId { get; set; }
        public int? Count5 { get; set; }
        public int? Count10 { get; set; }
        public int? Count20 { get; set; }
        public int? Count50 { get; set; }
        public int? Count100 { get; set; }
        public int? Count200 { get; set; }
        public int? Count500 { get; set; }
        public int? Count1000 { get; set; }
        public decimal? Total { get; set; }
        public int? Others { get; set; }
        public int? Field1 { get; set; }
        public int? Field2 { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
    }
}
