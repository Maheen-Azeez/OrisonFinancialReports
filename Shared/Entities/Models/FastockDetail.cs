using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class FastockDetail
    {
        public int? Id { get; set; }
        public DateTime? Date { get; set; }
        public string BarCode { get; set; }
        public string Status { get; set; }
        public string VarField1 { get; set; }
        public string VarField2 { get; set; }
        public int? NumField1 { get; set; }
        public int? NumField2 { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
    }
}
