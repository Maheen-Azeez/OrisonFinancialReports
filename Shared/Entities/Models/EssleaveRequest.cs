using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class EssleaveRequest
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string LeaveType { get; set; }
        public decimal? Duration { get; set; }
        public string Reason { get; set; }
    }
}
