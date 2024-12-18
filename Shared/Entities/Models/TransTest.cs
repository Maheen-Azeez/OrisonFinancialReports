using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class TransTest
    {
        public int? Vno { get; set; }
        public DateTime? Vdate { get; set; }
        public int? StaffId { get; set; }
        public string Stype { get; set; }
        public int? CustId { get; set; }
        public string Taxcode { get; set; }
        public string Vattype { get; set; }
        public int? ItemId { get; set; }
        public int? Qty { get; set; }
        public int? Rate { get; set; }
        public int? Vatamt { get; set; }
        public int? Discount { get; set; }
        public int? NetAmount { get; set; }
        public DateTime? ModTime { get; set; }
    }
}
