using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrdailyScheduleMaster
    {
        public HrdailyScheduleMaster()
        {
            Hrdailyscheduledetails = new HashSet<Hrdailyscheduledetail>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? Vdate { get; set; }
        public int? CustId { get; set; }
        public int? ProjectId { get; set; }

        public virtual ICollection<Hrdailyscheduledetail> Hrdailyscheduledetails { get; set; }
    }
}
