using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrtimeSheet
    {
        public HrtimeSheet()
        {
            HrtimeSheetConsolidateds = new HashSet<HrtimeSheetConsolidated>();
            HrtimeSheetDetails = new HashSet<HrtimeSheetDetail>();
        }

        public int Id { get; set; }
        public int EmpId { get; set; }
        public int? CardNo { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public DateTime? Date { get; set; }
        public string MainProject { get; set; }
        public string RollNo { get; set; }
        public decimal? Thtotal { get; set; }
        public decimal? Nhtotal { get; set; }
        public decimal? Ottotal { get; set; }
        public decimal? Hottotal { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public string Remarks { get; set; }
        public int? Fridays { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Days { get; set; }
        public decimal? Fottotal { get; set; }

        public virtual Account Emp { get; set; }
        public virtual ICollection<HrtimeSheetConsolidated> HrtimeSheetConsolidateds { get; set; }
        public virtual ICollection<HrtimeSheetDetail> HrtimeSheetDetails { get; set; }
    }
}
