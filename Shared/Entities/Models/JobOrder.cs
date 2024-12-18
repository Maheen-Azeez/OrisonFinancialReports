using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class JobOrder
    {
        public int Id { get; set; }
        public string VoucherNo { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public DateTime? Date { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }
}
