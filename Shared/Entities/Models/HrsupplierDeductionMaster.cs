using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrsupplierDeductionMaster
    {
        public int Id { get; set; }
        public string Refno { get; set; }
        public DateTime? Date { get; set; }
        public string Narration { get; set; }
        public string Month { get; set; }
        public decimal? Amount { get; set; }
        public int? AccId { get; set; }
        public bool? Status { get; set; }
    }
}
