using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Wpsmaster
    {
        public Wpsmaster()
        {
            Wpstrans = new HashSet<Wpstran>();
        }

        public int Id { get; set; }
        public DateTime? PayStartDate { get; set; }
        public string PayEndDate { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int? DaysInPeriod { get; set; }
        public string AgentId { get; set; }
        public int CompanyId { get; set; }
        public DateTime? FileCdate { get; set; }
        public string FileCtime { get; set; }

        public virtual ICollection<Wpstran> Wpstrans { get; set; }
    }
}
