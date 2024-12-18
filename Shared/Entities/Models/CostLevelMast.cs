using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class CostLevelMast
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public int? Cuid { get; set; }
    }
}
