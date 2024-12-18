using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdeductionMultidetail
    {
        public int Id { get; set; }
        public int? Did { get; set; }
        public int? EmpId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }

        public virtual HrdeductionMulti DidNavigation { get; set; }
        public virtual Account Emp { get; set; }
    }
}
