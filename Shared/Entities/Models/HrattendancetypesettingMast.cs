using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrattendancetypesettingMast
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Atttype { get; set; }
        public string Remarks { get; set; }
        public bool? Posted { get; set; }
    }
}
