using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrmobilizationDetailed
    {
        public int Id { get; set; }
        public int? MobId { get; set; }
        public int? EmpId { get; set; }
        public int? DesignationId { get; set; }
        public string AccStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? MobDate { get; set; }
        public DateTime? DeMobDate { get; set; }
        public string DemobReason { get; set; }
        public string Status { get; set; }
        public int? FromProject { get; set; }
        public int? FromMob { get; set; }
        public int? ToProject { get; set; }
        public string Shift { get; set; }

        public virtual HrmobilizationMaster Mob { get; set; }
    }
}
