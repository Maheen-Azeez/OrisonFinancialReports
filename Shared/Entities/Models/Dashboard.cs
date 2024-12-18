using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Dashboard
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public string DisplayText { get; set; }
        public string ToolTipText { get; set; }
        public bool Visible { get; set; }
        public string Module { get; set; }
        public int? Userid { get; set; }
        public string Tag { get; set; }
        public int? OrderNo { get; set; }
        public int? BranchId { get; set; }
    }
}
