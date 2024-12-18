using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempWagesIncome
    {
        public int Id { get; set; }
        public int Wiid { get; set; }
        public decimal? Numbers { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string Wages { get; set; }
        public int? DaysWorked { get; set; }
        public decimal? Actual { get; set; }
        public decimal? Days { get; set; }

        public virtual HrempWage Wi { get; set; }
    }
}
