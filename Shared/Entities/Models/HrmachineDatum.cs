using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmachineDatum
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? CheckTime { get; set; }
        public bool? CheckType { get; set; }
        public int? VerifyCode { get; set; }
        public int? SensorId { get; set; }
        public int? WorkCode { get; set; }
        public int? UserExtFmt { get; set; }
        public string Branch { get; set; }
    }
}
