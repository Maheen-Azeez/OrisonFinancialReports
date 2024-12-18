using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrsalaryDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal? PerAmount { get; set; }
        public int? AllowanceId { get; set; }
    }
}
