using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdayTypeMaster
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal? DayValue { get; set; }
        public decimal? RateValue { get; set; }
    }
}
