using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AttendanceInOutTime
    {
        public bool? Id { get; set; }
        public string Department { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string SatInTime { get; set; }
        public string SatOutTime { get; set; }
    }
}
