using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class ReportCategory
    {
        public ReportCategory()
        {
            Reports = new HashSet<Report>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public int? Order { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
