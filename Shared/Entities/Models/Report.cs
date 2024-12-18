using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Report
    {
        public int RepId { get; set; }
        public string RepName { get; set; }
        public int? RepCat { get; set; }
        public string RepDest { get; set; }
        public bool? Active { get; set; }

        public virtual ReportCategory RepCatNavigation { get; set; }
    }
}
