using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EmpWageSheetItem
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public DateTime? WageDate { get; set; }
        public int? ProjectId { get; set; }
        public decimal? Wt { get; set; }
        public decimal? Wtot { get; set; }
        public decimal? Wh { get; set; }
        public decimal? Whot { get; set; }
        public decimal? Dt { get; set; }
        public decimal? Dtot { get; set; }
        public decimal? Dh { get; set; }
        public decimal? Dhot { get; set; }
        public decimal? Dsh { get; set; }
        public decimal? Dshot { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }

        public virtual EmpWageSheet Parent { get; set; }
    }
}
