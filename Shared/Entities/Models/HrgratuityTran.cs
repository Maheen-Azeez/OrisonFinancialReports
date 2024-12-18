using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrgratuityTran
    {
        public int Id { get; set; }
        public int GrId { get; set; }
        public string Income { get; set; }
        public string Remarks { get; set; }
        public decimal? Amount { get; set; }
        public string Type { get; set; }

        public virtual HrgratuityParent Gr { get; set; }
    }
}
