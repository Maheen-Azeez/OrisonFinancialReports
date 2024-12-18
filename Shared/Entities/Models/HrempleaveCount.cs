using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrempleaveCount
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public int? LeavePerYear { get; set; }
        public bool? BalanceStatus { get; set; }
    }
}
