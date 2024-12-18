using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrattendancetypesetting
    {
        public int Id { get; set; }
        public int? Empid { get; set; }
        public string Atttype { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Remarks { get; set; }
        public int? Userid { get; set; }
    }
}
