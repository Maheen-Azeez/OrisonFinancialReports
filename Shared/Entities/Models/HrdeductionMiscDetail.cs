using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdeductionMiscDetail
    {
        public int Id { get; set; }
        public int Did { get; set; }
        public int? EmpId { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Days { get; set; }
        public decimal? TotalBalance { get; set; }
        public int? Craccount { get; set; }

        public virtual HrdeductionMisc DidNavigation { get; set; }
    }
}
