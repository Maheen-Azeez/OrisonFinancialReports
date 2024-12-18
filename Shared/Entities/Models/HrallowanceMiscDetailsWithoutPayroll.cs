using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrallowanceMiscDetailsWithoutPayroll
    {
        public int Id { get; set; }
        public int Aid { get; set; }
        public int EmpId { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Days { get; set; }
        public int? DebitId { get; set; }

        public virtual HrallowanceMiscwithoutPayroll AidNavigation { get; set; }
    }
}
