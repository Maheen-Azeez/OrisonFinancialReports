using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class Hrmobilization
    {
        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime Date { get; set; }
        public int ProjectId { get; set; }
        public int EmpId { get; set; }
        public DateTime? Mob { get; set; }
        public DateTime? DeMob { get; set; }
        public int? DesignId { get; set; }
        public string Remarks { get; set; }
        public string Mobilize { get; set; }
        public long? Exported { get; set; }

        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
        public virtual HrmobilizeMaster MobilizeNavigation { get; set; }
        public virtual CostCentre Project { get; set; }
    }
}
