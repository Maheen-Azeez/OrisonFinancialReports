using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonMIS.Shared.Models
{
    public partial class HrsalaryIncrementMast
    {
        public HrsalaryIncrementMast()
        {
            HrsalaryIncrementAllowanceDetails = new HashSet<HrsalaryIncrementAllowanceDetail>();
            HrsalaryIncrementEmpDetails = new HashSet<HrsalaryIncrementEmpDetail>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public DateTime? RefDate { get; set; }
        public string Remarks { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public string Month { get; set; }
        public int? Year { get; set; }
        public bool? Posted { get; set; }

        public virtual ICollection<HrsalaryIncrementAllowanceDetail> HrsalaryIncrementAllowanceDetails { get; set; }
        public virtual ICollection<HrsalaryIncrementEmpDetail> HrsalaryIncrementEmpDetails { get; set; }
    }
}
