using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hremptiming
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public string Lp1 { get; set; }
        public string Lp2 { get; set; }
        public string Lp3 { get; set; }
        public string Ep1 { get; set; }
        public string Ep2 { get; set; }
        public string Ep3 { get; set; }
        public string NormalHrs { get; set; }
        public string SatHrs { get; set; }
        public string LateTime { get; set; }
    }
}
