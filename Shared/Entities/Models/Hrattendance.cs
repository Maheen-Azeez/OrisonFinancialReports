using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrattendance
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime Date { get; set; }
        public string EmpIn { get; set; }
        public string EmpOut { get; set; }
        public decimal? Th { get; set; }
        public decimal? Nh { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Hot { get; set; }
        public int? Thchanged { get; set; }
        public string ActualIn { get; set; }
        public string ActualOut { get; set; }
        public string In { get; set; }
        public string Out { get; set; }
        public string InStatus { get; set; }
        public string OutStatus { get; set; }
        public string AttType { get; set; }
        public string Remarks { get; set; }
        public decimal? LateHours { get; set; }
        public string ActualAtttype { get; set; }
        public string Branch { get; set; }
        public int? LeaveId { get; set; }
    }
}
