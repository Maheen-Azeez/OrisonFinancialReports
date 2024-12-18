using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrdailyscheduledetail
    {
        public int Id { get; set; }
        public int Did { get; set; }
        public int? EmpId { get; set; }
        public DateTime? FromDate { get; set; }
        public decimal? Hours { get; set; }
        public int? DesignId { get; set; }
        public string Remarks { get; set; }

        public virtual HrdailyScheduleMaster DidNavigation { get; set; }
    }
}
