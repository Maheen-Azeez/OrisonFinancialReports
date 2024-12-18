using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdayMaster
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Day { get; set; }
        public string DayOfWeek { get; set; }
    }
}
