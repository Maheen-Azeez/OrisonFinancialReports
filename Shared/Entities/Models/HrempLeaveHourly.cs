using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempLeaveHourly
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        public decimal? Duration { get; set; }
        public bool? IsPaid { get; set; }
        public DateTime? Dates { get; set; }
        public string Remarks { get; set; }
    }
}
