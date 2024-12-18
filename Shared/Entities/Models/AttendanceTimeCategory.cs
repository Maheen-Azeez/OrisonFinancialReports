using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class AttendanceTimeCategory
    {
        public int Id { get; set; }
        public int? TimeId { get; set; }
        public string Type { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
    }
}
