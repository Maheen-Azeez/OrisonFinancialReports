using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrprojectAttendance
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int EmpId { get; set; }
        public DateTime Date { get; set; }
        public bool? Leave { get; set; }
        public string Reason { get; set; }

        public virtual Account Emp { get; set; }
        public virtual CostCentre Project { get; set; }
    }
}
