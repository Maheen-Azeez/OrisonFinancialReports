using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Transtock
    {
        public string ItemCode { get; set; }
        public string Barcode { get; set; }
        public string Itemname { get; set; }
        public int? Quantity { get; set; }
    }
}
