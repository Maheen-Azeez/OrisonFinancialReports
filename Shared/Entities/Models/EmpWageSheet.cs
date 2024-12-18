using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EmpWageSheet
    {
        public EmpWageSheet()
        {
            EmpWageSheetItems = new HashSet<EmpWageSheetItem>();
        }

        public int Id { get; set; }
        public int Reference { get; set; }
        public DateTime Date { get; set; }
        public decimal? Wtrate { get; set; }
        public decimal? Whrate { get; set; }
        public decimal? Wtotrate { get; set; }
        public decimal? Whotrate { get; set; }
        public decimal? Dtrate { get; set; }
        public decimal? Dtotrate { get; set; }
        public decimal? Dhrate { get; set; }
        public decimal? Dhotrate { get; set; }
        public decimal? Dshrate { get; set; }
        public decimal? Dshotrate { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public decimal? GrandTotal { get; set; }
        public int? ForemanId { get; set; }
        public int? CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<EmpWageSheetItem> EmpWageSheetItems { get; set; }
    }
}
