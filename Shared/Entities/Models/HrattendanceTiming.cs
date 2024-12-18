using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrattendanceTiming
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string DayType { get; set; }
        public string PunchType { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string LateTime { get; set; }
        public string EarlyPunch { get; set; }
        public string MaxLatepunch { get; set; }
        public string MaxEarlyPunch { get; set; }
        public string NormalTime { get; set; }
        public string HinTime { get; set; }
        public string HoutTime { get; set; }
        public string SatLatePunch { get; set; }
        public string SatEarlyPunch { get; set; }
        public string SatMaxLatePunch { get; set; }
        public string SatMaxEarlyPunch { get; set; }
        public bool? Hstatus { get; set; }
    }
}
