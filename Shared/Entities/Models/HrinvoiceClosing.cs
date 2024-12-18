using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrinvoiceClosing
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public int? Year { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
    }
}
