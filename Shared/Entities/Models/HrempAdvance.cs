using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempAdvance
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? Installment { get; set; }
        public DateTime? StartDate { get; set; }
        public string Type { get; set; }
        public string Remarks { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? Date { get; set; }
    }
}
