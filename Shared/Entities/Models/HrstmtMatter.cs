using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrstmtMatter
    {
        public int Id { get; set; }
        public string Matter { get; set; }
        public int? BranchId { get; set; }
        public string Category { get; set; }
    }
}
