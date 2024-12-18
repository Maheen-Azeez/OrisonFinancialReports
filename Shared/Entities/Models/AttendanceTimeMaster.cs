using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AttendanceTimeMaster
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string SatInTime { get; set; }
        public string SatOutTime { get; set; }
        public int? NormalHours { get; set; }
        public int? SatHours { get; set; }
        public string GraceTime { get; set; }
    }
}
