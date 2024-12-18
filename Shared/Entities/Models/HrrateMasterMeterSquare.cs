using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrrateMasterMeterSquare
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int DesignId { get; set; }
        public decimal? M2rate { get; set; }
        public decimal? BasicSalary { get; set; }

        public virtual MastDesignation Design { get; set; }
        public virtual Account Emp { get; set; }
    }
}
