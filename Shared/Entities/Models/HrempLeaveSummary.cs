using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempLeaveSummary
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Leave { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}
