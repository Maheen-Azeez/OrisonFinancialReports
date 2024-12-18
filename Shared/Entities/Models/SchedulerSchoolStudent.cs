using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class SchedulerSchoolStudent
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public int? StudentCount { get; set; }
        public string Type { get; set; }
    }
}
