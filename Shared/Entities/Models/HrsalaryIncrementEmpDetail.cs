using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrsalaryIncrementEmpDetail
    {
        public HrsalaryIncrementEmpDetail()
        {
            HrsalaryIncrementAllowanceDetails = new HashSet<HrsalaryIncrementAllowanceDetail>();
        }

        public int Id { get; set; }
        public int Siid { get; set; }
        public int? EmpId { get; set; }
        public decimal? OldSalary { get; set; }
        public decimal? NewSalary { get; set; }
        public decimal? Basic { get; set; }

        public virtual Account Emp { get; set; }
        public virtual HrsalaryIncrementMast Si { get; set; }
        public virtual ICollection<HrsalaryIncrementAllowanceDetail> HrsalaryIncrementAllowanceDetails { get; set; }
    }
}
